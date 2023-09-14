using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class AnimalBase
    {
        public string Name { get; set; }

        public abstract string GetVoice();

        public virtual string GetPaw()
        {
            return String.Empty;
        }
    }
}
