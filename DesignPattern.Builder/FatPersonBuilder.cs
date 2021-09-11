namespace DesignPattern.Builder
{
    /// <summary>
    /// 建造者具体实现：胖子
    /// </summary>
    public class FatPersonBuilder : Builder
    {
        public override void BuildArm()
        {
            Person.Arm = "FatPerson Arm";
        }

        public override void BuildBody()
        {
            Person.Body = "FatPerson Body";
        }

        public override void BuildHead()
        {
            Person.Head = "FatPerson Head";
        }

        public override void BuildLeg()
        {
            Person.Leg = "FatPerson Leg";
        }
    }
}
