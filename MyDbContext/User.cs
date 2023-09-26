using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDbContext
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(127)]
        public string Name { get; set; }
        [Required]
        [StringLength(127)]
        public string Email { get; set; }
        [Required]
        [StringLength(127)]
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
