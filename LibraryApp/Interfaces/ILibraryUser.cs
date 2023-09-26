using System.Net.Mail;

namespace LibraryApp;

public interface ILibraryUser
{
    Guid Id { get; set; }
    string Name { get; set; }
    double Rating { get; set; }
    MailAddress EMail { get; set; }
    string Phone { get; set; }
    string ToString();
}