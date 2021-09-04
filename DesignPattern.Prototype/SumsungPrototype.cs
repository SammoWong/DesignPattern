namespace DesignPattern.Prototype
{
    public class SumsungPrototype : MobilePhonePrototype
    {
        public SumsungPrototype(string brand) : base(brand)
        {
        }

        public override MobilePhonePrototype Clone()
        {
            return (MobilePhonePrototype)this.MemberwiseClone();
        }
    }
}