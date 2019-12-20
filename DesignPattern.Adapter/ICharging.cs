using System;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// 充电接口
    /// 定义充电标准
    /// </summary>
    public interface ICharging
    {
        void Charging();
    }

    /// <summary>
    /// 未实现充电标准接口
    /// </summary>
    public class USB
    {
        public void Charge()
        {
            Console.WriteLine("USB充电ing");
        }
    }

    /// <summary>
    /// 实现了充电标准
    /// </summary>
    public class USBMicro : ICharging
    {
        public void Charging()
        {
            Console.WriteLine("USBMicro充电ing");
        }
    }

    /// <summary>
    /// USBLightning适配器
    /// 类适配器模式
    /// </summary>
    public class USBLightningAdapter : USB, ICharging
    {
        public void Charging()
        {
            Console.WriteLine("接入USBLightning适配器");
            base.Charge();
        }
    }

    /// <summary>
    /// USBTypeC适配器
    /// 对象适配器模式
    /// </summary>
    public class USBTypeCAdapter : ICharging
    {
        private readonly USB _usb;
        public USBTypeCAdapter(USB usb)
        {
            _usb = usb;
        }
        public void Charging()
        {
            Console.WriteLine("接入USBTypeC适配器");
            _usb.Charge();
        }
    }
}
