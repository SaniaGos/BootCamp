using LibraryApp.Helper;
using LibraryApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class LibraryService : ILibraryService
    {
        private readonly Library _lib;

        public LibraryService(Library lib)
        {
            this._lib = lib;
        }

        public Guid GetIdByUserName(string name)
        {

            return _lib.Users.FirstOrDefault(x => x.Name == name).Id;
        }

        public Guid GetIdByTitle(string title)
        {
            return _lib.Books.FirstOrDefault(x => x.Title == title).Id;
        }

        public void SearchByTitle(string title)
        {bool success = false;
            foreach (var book in _lib.Books)
            {
                if (book.Title == title)
                {
                    Console.WriteLine(book.ToString() + '\n');
                    success = true;
                }
            }

            if (!success)
            {
                Console.WriteLine("Book not found!");
            }

            Console.WriteLine();
        }

        public void Search(GenreType genreType)
        {
            bool success = false;
            foreach (var book in _lib.Books)
            {
                if (book.GenreType == genreType)
                {
                    Console.WriteLine(book.ToString() + '\n');
                    success = true;
                }
            }

            if (!success)
            {
                Console.WriteLine("Book not found!");
            }

            Console.WriteLine();
        }

        public void Search(string author)
        {
            bool success = false;
            foreach (var book in _lib.Books)
            {
                if (book.Author == author)
                {
                    Console.WriteLine(book.ToString() + '\n');
                    success = true;
                }
            }

            if (!success)
            {
                Console.WriteLine("Book not found!");
            }

            Console.WriteLine();
        }

        public void PrintBooks(BookStatus status)
        {
            bool success = false;
            foreach (var book in _lib.Books)
            {
                if (book.RentInfo.Status == status)
                {
                    Console.WriteLine(book.ToString() + '\n');
                    success = true;
                }
            }

            if (!success)
            {
                Console.WriteLine("Book not found!");
            }

            Console.WriteLine();
        }

        public void AddBook(Book book)
        {
            _lib.Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _lib.Books.Remove(book);
        }

        public void AddUser(LibraryUser user)
        {
            _lib.Users.Add(user);
        }

        public void RemoveUser(LibraryUser user)
        {
            _lib.Users.Remove(user);
        }

        public void PrintBooks()
        {
            foreach (var book in _lib.Books)
            {
                Console.WriteLine(book.ToString() + '\n');
            }

            Console.WriteLine();
        }

        public void PrintUsers()
        {
            foreach (var user in _lib.Users)
            {
                Console.WriteLine(user.ToString());
                
            }

            Console.WriteLine();
        }

        public void PrintUsers(string name)
        {
            foreach (var user in _lib.Users)
            {
                if (user.Name == name)
                {
                    Console.WriteLine(user.ToString());
                }
            }

            Console.WriteLine();
        }

        public bool ReserveBook(Guid userId, Guid bookId, DateTime startDate, int numOfDaysReserve = 120)
        {
            var user = _lib.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                var book = _lib.Books.FirstOrDefault(x => x.Id == bookId);
                if (book != null && book.RentInfo.ReserveInfo.UserId == null && DateTime.Now < startDate)
                {
                    var rent = book.RentInfo;
                    var reserve = rent.ReserveInfo;
                    reserve.UserId = user.Id;
                    reserve.StartDate = startDate;
                    reserve.EndDate = startDate.AddDays(numOfDaysReserve);

                    rent.ReserveInfo = reserve;
                    book.RentInfo = rent;
                    return true;
                }
            }

            return false;
        }

        public bool TakeBook(Guid userId, Guid bookId, int numOfDaysRent = 120)
        {
            var user = _lib.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                var book = _lib.Books.FirstOrDefault(x => x.Id == bookId);
                if (book == null)
                {
                    Console.WriteLine("Book does not exist");
                    return false;
                }

                var reserveInfo = book.RentInfo.ReserveInfo;
                var endDate = DateTime.Now.AddDays(numOfDaysRent);
                // reserve check
                if (reserveInfo.UserId != user.Id &&
                    reserveInfo.StartDate < DateTime.Now && DateTime.Now < reserveInfo.EndDate ||
                    (reserveInfo.StartDate < endDate && endDate < reserveInfo.EndDate))
                {
                    Console.WriteLine("Book reserved");
                    return false;
                }

                if (book.RentInfo.Status == BookStatus.Available)
                {
                    var rent = book.RentInfo;
                    rent.Status = BookStatus.Issued;
                    rent.RentDate = DateTime.Now;
                    rent.EndDate = endDate;
                    rent.UserId = userId;
                    // rent.Price =

                    book.RentInfo = rent;
                    Console.WriteLine("Book taken");
                    return true;
                }
            }

            Console.WriteLine("User does not exist");
            return false;
        }

        public bool ReturnBook(Guid userId, Guid bookId)
        {
            var user = _lib.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                var book = _lib.Books.FirstOrDefault(x => x.Id == bookId);
                if (book != null && book.RentInfo.Status == BookStatus.Issued && book.RentInfo.UserId == user.Id)
                {
                    var rent = book.RentInfo;
                    rent.Status = BookStatus.Available;
                    rent.RentDate = null;
                    rent.EndDate = null;
                    rent.UserId = null;
                    // rent.Price =
                    book.RentInfo = rent;

                    user.Rating++;

                    return true;
                }
            }

            return false;
        }
    }
}