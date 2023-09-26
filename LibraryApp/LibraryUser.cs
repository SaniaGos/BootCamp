using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using LibraryApp.Interfaces;

namespace LibraryApp
{
    public sealed class LibraryUser : ILibraryUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }

        public MailAddress EMail
        {
            get => _email;
            set => _email = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        private MailAddress _email;
        private string _phone;

        public override string ToString()
        {
            return $"name: {Name}\t   rating: {Rating} \t Id: {Id}";
        }
    }
}