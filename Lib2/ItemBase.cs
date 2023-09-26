using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib2
{
    public class ItemBase
    {
        public struct ItemInfo
        {
            int width;
            int height;
            int weight;
        }
        public string Name { get; set; }
        protected double Price { get; set; }
        protected ItemInfo itemInfo { get; set; }
    }
}
