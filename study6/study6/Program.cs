using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 이진수를 정수로 변환하기
            //Console.Write("이진수를 입력하세요");
            //string binaryInput = Console.ReadLine();
            //int decimalNumber = Convert.ToInt32(binaryInput, 2);

            //string binaryOutput = Convert.ToString(decimalNumber, 2);

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalNumber}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            //var name = "Alice"; //문자열로 추론
            //var age = 25;   //정수로 추론
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이: {age}, 학생 여부: {isStudent}");

            int defaultInt = default;
            string defaultString = default;
            bool defaultBool = default;

            //Console.WriteLine($"정수 기본값 : {defaultInt}");
            //Console.WriteLine($"문자열 기본값 : {defaultString}");
            //Console.WriteLine($"논리 기본값 : {defaultBool}");

            //int c = 0, d = 0;

            //c = 10;
            //d = 3;
            //sum = c % d;  //나머지구하는 연산자
            //Console.WriteLine($"합 : {sum}");



            //int number = 7;
            //int sum = 0;
            //sum = number % 2;  // 0나오면 짝수   1 홀수
            //Console.WriteLine("짝수 홀수 판별 : " + sum);

            //bool isEqual = false; // 거짓 0
            //int a = 5;
            //int b = 5;
            ////관계형 연산자
            //isEqual = (a == b); //a 랑 b랑 같은가?
            //Console.WriteLine("같은가? " + isEqual);

            //int number = 5;
            //bool flag = true;


            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5

            //Console.WriteLine(!flag);  //논리 부정 : false  

            //int num = 10;
            //int result = ~num;
            //Console.WriteLine(result);

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;

            //average = (float)sum / 3;  //평균

            //Console.WriteLine("총점 : " + sum);
            //Console.WriteLine("평균 : " + average);

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine(firstName + " " + lastName); //출력

            //int ab = 10;
            //ab += 5;  // a  = a + 5;

            //Console.WriteLine(ab);

            //int ac = 10;
            //ac += 5;  // a  = a + 5;
            //Console.WriteLine(a);
            //ac -= 5;  // a  = a - 5;
            //Console.WriteLine(a);
            //ac *= 5;  // a  = a * 5;
            //Console.WriteLine(a);
            //ac /= 5;  // a  = a / 5;
            //Console.WriteLine(a);
            //ac %= 5;  // a  = a % 5;
            //Console.WriteLine(a);

            //Console.Write("국어 점수 입력하세요 : ");
            //int a1 = int.Parse(Console.ReadLine());
            //Console.Write("영어 점수 입력하세요 : ");
            //int a2 = int.Parse(Console.ReadLine());
            //Console.Write("수학 점수 입력하세요 : ");
            //int a3 = int.Parse(Console.ReadLine());

            //int sum = a1 + a2 + a3;
            //float av = (float)sum / 3;
            //Console.Write($"총점 : {sum}, 평균 : {av:F2}");

            //Console.Write("정수를 입력하세요 : ");
            //int a1 = int.Parse(Console.ReadLine());
            //string a2 = Convert.ToString(a1, 2);
            //Console.WriteLine($"이진수 : {a2}");
            //int num = Convert.ToInt32(a2);
            //int inverted = ~num;
            //string a3 = Convert.ToString(inverted, 2);
            //Console.WriteLine($"반전 : {a3}");

            //int b = 3;

            ////전위 ++b , 후위 b++

            //Console.WriteLine("b의 값은 : " + (b++));

            //int x = 5, y = 10;

            //Console.WriteLine(x == y);  // false
            //Console.WriteLine(x != y);  // true
            //Console.WriteLine(x < y);   // true
            //Console.WriteLine(x > y);   // false
            //Console.WriteLine(x >= y);  // false
            //Console.WriteLine(x <= y);  //true  

            //bool a = false;
            //bool b = false;
            ////Not
            ////!a

            //b = !a;

            //Console.WriteLine(b); //true 

            ////비트연산자
            //int x = 5; // 0101
            //int y = 3; // 0011 

            //Console.WriteLine(x & y); //AND : 1 (0001)
            //Console.WriteLine(x | y); //OR : 7 (0111)
            //Console.WriteLine(x ^ y); //XOR :6   (0110)
            //Console.WriteLine(~x);    //NOT : -6 

            //int value = 4;  //0100

            //Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //오른쪽이동: 2 (0010)    int value = 4;  //0100

            //Console.WriteLine(value << 1); //왼쪽이동 : 8 (1000)
            //Console.WriteLine(value >> 1); //오른쪽이동: 2 (0010)

            //int a = 10, b = 20;

            //int max;

            //max = (a < b) ? a : b; //삼항 연산자

            //Console.WriteLine(max);

            //int key = 1;

            //string str;
            //str = (key == 2) ? "문이열렸습니다." : "문을 못열었습니다.";

            //Console.WriteLine(str);

            //int score = 85;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A 학점");
            //}
            //else
            //{
            //    Console.WriteLine("B 학점");
            //}

            //1단계
            //가지고있는 소지금을 입력하세요 :
            //0~100  무한의대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4
            //401~500 엑스칼리버 +5
            //501~600 유령검 +6

            //2단계
            //캐릭터 이름
            //공격력 : 100 + 1 

            //Console.Write("소지금을 입력하세요 : ");
            //int num = int.Parse(Console.ReadLine());
            //string name = "검사1";
            //int attack = 100;

            //if(num >=0 && num <= 100)
            //{
            //    Console.WriteLine("무한의 대검 구매");
            //    attack += 1;
            //}
            //else if (num >= 101 && num <= 200)
            //{
            //    Console.WriteLine("카타나 구매");
            //    attack += 2;
            //}
            //else if (num >= 201 && num <= 300)
            //{
            //    Console.WriteLine("진은검 구매");
            //    attack += 3;
            //}
            //else if (num >= 301 && num <= 400)
            //{
            //    Console.WriteLine("집판검 구매");
            //    attack += 4;
            //}
            //else if (num >= 401 && num <= 500)
            //{
            //    Console.WriteLine("엑스칼리버 구매");
            //    attack += 5;
            //}
            //else if (num >= 501 && num <= 600)
            //{
            //    Console.WriteLine("유령검 구매");
            //    attack += 6;
            //}

            //Console.WriteLine($"이름 : {name}");
            //Console.WriteLine($"공격력 : {attack}");

            Console.WriteLine("정수 3개를 입력하세요 ex) 1,2,3");
            List<int> ls = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            int max = Math.Max(ls[0], Math.Max(ls[1], ls[2]));
            Console.WriteLine($"최대값 : {max}");

            Console.WriteLine("점수를 입력하세요 ex) 10");
            int a = int.Parse(Console.ReadLine());
            string grade;
            if (a >= 90) grade = "A";
            else if (a >= 80) grade = "B";
            else if (a >= 70) grade = "C";
            else if (a >= 60) grade = "D";
            else grade = "F";
            Console.WriteLine($"성적 : {grade}");

            Console.Write("첫 숫자 입력 : ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 숫자 입력 : ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("연산자 입력 : ");
            string a3 = Console.ReadLine();

            if(a3 == "+") Console.Write($"결과 : {a1+a2}");
            if(a3 == "-") Console.Write($"결과 : {a1-a2}");
            if(a3 == "*") Console.Write($"결과 : {a1*a2}");
            if(a2 == 0) Console.Write($"0으로 나눌 수 없음");
            else if(a3 == "/") Console.Write($"결과 : {a1/a2}");



        }
    }
}
