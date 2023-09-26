using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Helper
{
    public struct RentInfo
    {
        public Guid? RentId { get; set; }
        public Guid BookId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? RentDate { get; set; }
        public DateTime? EndDate { get; set; }
        public BookStatus Status { get; set; }
        public ReserveInfo ReserveInfo { get; set; }
        public decimal Price { get; set; }
    }
}