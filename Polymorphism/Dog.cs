using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Dog : AnimalBase, IAnimal
    {
        public override string GetVoice()
        {
            return "Howl";
        }

        public void GetVoice(uint count)
        {
            throw new NotImplementedException();
        }

        public void GetVoice(string addCommand)
        {
            throw new NotImplementedException();
        }

        public void GetVoice(uint count, bool isToRepeat = true)
        {
            throw new NotImplementedException();
        }

        public void GoPlay()
        {
            throw new NotImplementedException();
        }
    }
}