using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace TodayTask1
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDCHANGE = 0x02;
        static void SetWallpaper(string imagePath)
        {
            // 바탕화면 변경
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagePath, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE);
            Console.WriteLine("바탕화면이 변경되었습니다.");
        }

        static void Main(string[] args)
        {
          
            // 로딩바 시작화면
            // 게임스토리1

            Console.WriteLine("엔터를 치면 게임이 시작됩니다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("이것은 공포게임이며 어린이, 임산부, 노약자, 심약자는 주의하시기 바랍니다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 지금 집에 있습니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 성인입니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 지금 혼자 있습니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 종종 우울합니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 종종 우울합니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 종종 우울합니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 이 게임이 무엇인지 궁금합니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 신이 존재함을 믿습니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 신이 선하다고 생각합니까? y or n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신은 불우 이웃을 돕습니까? y or n");
            String a = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("당신의 컴퓨터는 곧 랜섬웨어 감염됩니다..3");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("당신의 컴퓨터는 곧 랜섬웨어 감염됩니다..2");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("당신의 컴퓨터는 곧 랜섬웨어 감염됩니다..1");
            Thread.Sleep(1000);
            Console.Clear();

            string imagePath = @"C:\Users\xnTjazp2zm\Documents\b.png";
            SetWallpaper(imagePath);

            if (a == "y")
            {
                while(true)
                {
                    Console.WriteLine("게임이 끝났습니다.");
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("게임이 끝났습니다.");
                }
            }
            
        }
    }
}
