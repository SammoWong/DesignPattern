using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 建造者模式中的指挥者
    /// </summary>
    public class PersonDirector
    {
        Builder _builder;
        public PersonDirector(Builder builder)
        {
            _builder = builder;
        }

        /// <summary>
        /// 返回Person
        /// </summary>
        /// <returns></returns>
        public Person BuildPerson()
        {
            _builder.BuildArm();
            _builder.BuildBody();
            _builder.BuildHead();
            _builder.BuildLeg();

            return _builder.GetPerson();
        }
    }
}
