using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceType
{
    public static class AdressHelper
    {
        public static unsafe string GetAddress(this object obj)
        {
            TypedReference tr = __makeref(obj);
            
            IntPtr ptr = **(IntPtr**)(&tr);
            
            return "0x" + ptr.ToString("X");
        }

        public static unsafe string GetAddress(ref object obj)
        {
            TypedReference tr = __makeref(obj);

            IntPtr ptr = **(IntPtr**)(&tr);

            return "0x" + ptr.ToString("X");
        }
    }
}
