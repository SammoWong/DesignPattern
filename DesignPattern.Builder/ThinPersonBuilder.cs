namespace DesignPattern.Builder
{
    /// <summary>
    /// 建造者具体实现：瘦子
    /// </summary>
    public class ThinPersonBuilder : Builder
    {
        public override void BuildArm()
        {
            Person.Arm = "ThinPerson Arm";
        }

        public override void BuildBody()
        {
            Person.Body = "ThinPerson Body";
        }

        public override void BuildHead()
        {
            Person.Head = "ThinPerson Head";
        }

        public override void BuildLeg()
        {
            Person.Leg = "ThinPerson Leg";
        }
    }
}
