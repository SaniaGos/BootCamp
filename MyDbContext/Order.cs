using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDbContext
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [StringLength(127)]
        public string Name { get; set; }
        [Required]
        [StringLength(512)]
        public string Description { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public decimal TotalPrice { get; set; }
        [Required]
        [Range(0, 100)]
        public int Discount { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
