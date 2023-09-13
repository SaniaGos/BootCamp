using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string GetVoice()
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

        public void GoPlay()
        {
            throw new NotImplementedException();
        }
    }
}
