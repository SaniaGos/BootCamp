using System;
using System.Net.Mail;
using LibraryApp.Helper;
using static LibraryApp.Helper.TestData;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            Library lib = new Library()
            {
                Books = new List<Book>(),
                Users = new List<LibraryUser>(),
                Address = "15 Karpatska street, Ivano-Frankivsk, Ivano-Frankivsk region, 76000",
                Phone = "0342 504 763",
                Site = "https://library.nung.edu.ua/",
                WorkHours = "09:00-17:00"
            };

            LibraryService libraryService = new LibraryService(lib);

            for (int i = 0; i < 10; i++)
            {
                libraryService.AddUser(new LibraryUser()
                {
                    Id = Guid.NewGuid(),
                    Name = fullnames[i],
                    EMail = new MailAddress(mails[i]),
                    Phone = phones[i],
                    Rating = 0
                });

                libraryService.AddBook(new Book()
                {
                    Id = Guid.NewGuid(),
                    GenreType = (GenreType)random.Next(14),
                    Title = bookNames[i],
                    Author = authors[i],
                    BookInfo = new BookInfo()
                    {
                        PagesCount = random.Next(100, 500),
                        PublishingHouse = houses[i],
                        PublicationDate = new DateOnly(random.Next(1990, 2023), random.Next(1, 12), random.Next(1, 31)),
                        Weight = random.NextDouble() * (5.0 - 0.5) + 0.5,
                        Language = languages[random.Next(4)]
                    },
                    RentInfo = new RentInfo()
                    {
                        RentId = null,
                        BookId = Guid.NewGuid(),
                        UserId = null,
                        RentDate = null,
                        EndDate = null,
                        Price = 0,
                        Status = BookStatus.Available,
                        ReserveInfo = new ReserveInfo()
                        {
                            UserId = null,
                            StartDate = null,
                            EndDate = null
                        }
                    }
                });
            }

            libraryService.TakeBook(libraryService.GetIdByUserName("John Smith"),
                libraryService.GetIdByTitle("Beyond the Horizon"), 7);

            libraryService.PrintUsers();

            libraryService.PrintBooks();

            libraryService.ReturnBook(libraryService.GetIdByUserName("John Smith"),
                libraryService.GetIdByTitle("Beyond the Horizon"));

            libraryService.PrintUsers("John Smith");
        }
    }
}