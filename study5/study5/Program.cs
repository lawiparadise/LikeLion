using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = -100;
            long longValue = 1234567890L;

            Console.WriteLine(longValue);

            byte unsignedByte = 255;
            ushort unsignedShort = 65000;
            uint unsignedInt = 400000000;
            decimal highPrecision = 3.14159265351278291m;

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedInt);
            Console.WriteLine(highPrecision);

            Console.WriteLine("hello world alice");

            System.Int32 number = 123;
            System.String text = "hello";

            String a = number.ToString(); // 래퍼

            bool fal = false;
            Console.WriteLine(fal);
        }
    }
}
