using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 要建造的人
    /// </summary>
    public class Person
    {
        public string Head { get; set; }

        public string Body { get; set; }

        public string Arm { get; set; }

        public string Leg { get; set; }
    }
}
