using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCamp
{
    public interface IUser
    {
        public abstract Guid Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
}
