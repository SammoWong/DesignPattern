using System;

namespace DesignPattern.Factory.V1
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("数据库日志");
        }
    }
}