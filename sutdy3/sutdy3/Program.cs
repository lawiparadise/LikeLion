using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sutdy3
{
    class MyClass
    {
        public string Name { get; set; }
        public void Greet() => Console.WriteLine($"Hello, {Name}!");
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 리터럴
            int number = 10;
            double pi = 3.14;
            char letter = 'A';
            string name = "Alice";

            int hp = 100;
            float att = 56.7F;
            string characterName = "나임";
            char grade = 'S';
          

            Console.WriteLine(number);
            Console.WriteLine(pi);

            Console.WriteLine(letter);

            var obj = new sutdy3.MyClass { Name = "Alice" };
            obj.Greet();

        }
    }
}
