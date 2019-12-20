using System;

namespace DesignPattern.Factory.V1
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志");
        }
    }
}