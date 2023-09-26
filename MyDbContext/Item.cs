using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDbContext
{
    public class Item
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(127)]
        public string Name { get; set; }
        
        [Range(0, float.MaxValue)]
        public float Weight { get; set; }
        
        [Range(0, float.MaxValue)]
        public float Height { get; set; }
        
        [Range(0, float.MaxValue)]
        public float Width { get; set; }
        
        [Range(0, float.MaxValue)]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
    }
}
