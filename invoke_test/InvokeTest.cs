using System;

namespace invoke_test
{
    public class InvokeTest
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("invoke test start.....");

            // invoke some dll...
            InvokeSample();

            Console.WriteLine("invoke test end.....");
            Console.WriteLine("----------------------------------");
        }
        public static void InvokeSample()
        {
            Console.WriteLine("invoke sample here.....");
        }
    }
}
