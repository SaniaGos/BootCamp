﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Dog : IAnimal
    {
        public string GetVoice()
        {
            return "Howl";
        }
    }
}
