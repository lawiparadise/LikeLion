using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study4
{
    class Program
    {
        static void Main(string[] args)
        {
            int attack = 16755; // 공격력
            int maxHp = 78103; // 최대 생명력

            int critical = 36; // 치명
            int specialization = 1017; // 특화
            int domination = 41; // 제압
            int swiftness = 611; // 신속
            int endurance = 22; // 인내
            int expertise = 39; // 숙련

            Console.WriteLine("공격력"+attack);
            Console.WriteLine("최대 생명력" + maxHp);
            Console.WriteLine("치명" + critical);
            Console.WriteLine("특화" + specialization);
            Console.WriteLine("제압" + domination);
            Console.WriteLine("신속" + swiftness);
            Console.WriteLine("인내" + endurance);
            Console.WriteLine("숙련" + expertise);
        }
    }
}
