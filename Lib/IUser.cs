using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCamp
{
    public interface IUser
    {
        string SecondName { get; set; }
        Guid Id { get; set; }
        string FullName { get; set; }
        int Age { get; set; }
    }
}
