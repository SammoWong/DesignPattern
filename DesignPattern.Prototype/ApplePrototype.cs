using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class ApplePrototype : MobilePhonePrototype
    {
        public ApplePrototype(string brand) : base(brand)
        {

        }

        public override MobilePhonePrototype Clone()
        {
            return (MobilePhonePrototype)this.MemberwiseClone();
        }
    }
}
