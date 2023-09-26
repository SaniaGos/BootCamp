using LibraryApp.Helper;

namespace LibraryApp.Interfaces;

public interface ILibraryService
{
    Guid GetIdByUserName(string name);
    Guid GetIdByTitle(string title);
    void SearchByTitle(string title);
    void Search(GenreType genreType);
    void Search(string author);
    void PrintBooks(BookStatus status);
    void PrintBooks();
    void AddBook(Book book);
    void RemoveBook(Book book);
    void AddUser(LibraryUser user);
    void RemoveUser(LibraryUser user);
    void PrintUsers();
    void PrintUsers(string name);
    bool ReserveBook(Guid userId, Guid bookId, DateTime startDate, int numOfDaysReserve = 120);
    bool TakeBook(Guid userId, Guid bookId, int numOfDaysRent = 120);
    bool ReturnBook(Guid userId, Guid bookId);
}