using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Helper;
using LibraryApp.Interfaces;

namespace LibraryApp
{
    public class Library : ILibrary
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public string WorkHours { get; set; }
        public string Site { get; set; }
        public List<Book> Books { get; set; }
        public List<LibraryUser> Users { get; set; }
        
    }
}