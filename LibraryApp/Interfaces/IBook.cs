using LibraryApp.Helper;

namespace LibraryApp.Interfaces;

public interface IBook
{
    Guid Id { get; set; }
    GenreType GenreType { get; set; }
    string Title { get; set; }
    string Author { get; set; }
    BookInfo BookInfo { get; set; }
    RentInfo RentInfo { get; set; }
    string ToString();
}