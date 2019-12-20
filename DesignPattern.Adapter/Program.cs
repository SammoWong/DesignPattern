using System;

namespace DesignPattern.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //未实现充电标准的充电设备
            USB usb = new USB();
            usb.Charge();

            //实现充电标准接口
            USBMicro micro = new USBMicro();
            micro.Charging();

            //通过适配器充电
            Console.WriteLine("类适配器模式：");
            ICharging lightningAdapter = new USBLightningAdapter();
            lightningAdapter.Charging();

            //通过适配器充电
            Console.WriteLine("对象适配器模式：");
            ICharging typeCAdapter = new USBTypeCAdapter(usb);
            typeCAdapter.Charging();
            Console.ReadKey();
        }
    }
}
