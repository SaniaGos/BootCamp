using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Helper;
using LibraryApp.Interfaces;

namespace LibraryApp
{
    public class Book : IBook
    {
        public Guid Id { get; set; }
        public GenreType GenreType { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookInfo BookInfo { get; set; }
        public RentInfo RentInfo { get; set; }

        public override string ToString()
        {
            return $"title: {Title}\n" +
                   $"genre: {GenreType}\n" +
                   $"author: {Author}\n" +
                   $"date of publication: {BookInfo.PublicationDate}\n" +
                   $"status: {RentInfo.Status}";
        }
    }
}
