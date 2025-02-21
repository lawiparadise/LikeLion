using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요.");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"안녕하세요, {userName}");

            //Console.Write("나이를 입력하세요.");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"내년에는 {age++}살이 되겠군요!");
            //Console.WriteLine($"내년에는 {age}살이 되겠군요!");

            Console.Write($"루인 스킬 피해 입력 : ");
            string a = Console.ReadLine();
            float b = float.Parse(a);
            Console.WriteLine($"루인 스킬 피해 : {b} %");
            Console.WriteLine("");

            Console.Write($"카드 게이지 획득량 입력 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"카드 게이지 획득량 : {b} %");
            Console.WriteLine("");

            Console.Write($"각성기 피해 입력 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"각성기 피해 : {b} %");
            Console.WriteLine("");

            Console.Write($"최대 마나 입력 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"최대 마나 : {b}");
            Console.WriteLine("");

            Console.Write($"전투 중 마나 회복량 입력 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"전투 중 마나 회복량 : {b}");
            Console.WriteLine("");

            Console.Write($"비전투 중 마나 회복량 입력 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"비전투 중 마나 회복량 : {b}");
            Console.WriteLine("");

            Console.Write($"이동 속도 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"이동 속도 : {b:F1} %");
            Console.WriteLine("");

            Console.Write($"탈 것 속도 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"탈 것 속도 : {b:F1} %");
            Console.WriteLine("");

            Console.Write($"운반 속도 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"운반 속도 : {b:F1} %");
            Console.WriteLine("");

            Console.Write($"스킬 재사용 대기시간 감소 : ");
            a = Console.ReadLine();
            b = float.Parse(a);
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {b:F1} %");
            Console.WriteLine("");
        }
    }
}
