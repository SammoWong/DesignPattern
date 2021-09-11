using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 定义创建者接口，实现者必须实现该接口中定义的所有抽象方法，防止实现者疏忽而遗漏某个部件
    /// </summary>
    public abstract class Builder
    {
        protected Person Person { get; set; }

        public Builder()
        {
            Person = new Person();
        }

        // 建造头
        public abstract void BuildHead();
        // 建造身体
        public abstract void BuildBody();
        // 建造胳膊
        public abstract void BuildArm();
        // 建造腿
        public abstract void BuildLeg();

        /// <summary>
        /// 返回一个已经创建成功的对象
        /// </summary>
        /// <returns></returns>
        public Person GetPerson()
        {
            return Person;
        }
    }
}
