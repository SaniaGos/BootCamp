namespace LibraryApp.Interfaces;

public interface ILibrary
{
    string Phone { get; set; }
    string Address { get; set; }
    string WorkHours { get; set; }
    string Site { get; set; }
    List<Book> Books { get; set; }
    List<LibraryUser> Users { get; set; }
}