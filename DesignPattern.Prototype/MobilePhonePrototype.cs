using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public abstract class MobilePhonePrototype
    {
        public MobilePhonePrototype(string brand)
        {
            Brand = brand;
        }

        public string Brand { get; set; }

        public abstract MobilePhonePrototype Clone();
    }
}
