﻿namespace ShopMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("header");
            {
                Console.WriteLine("헤딩입니다");  // A#2
                Console.WriteLine("회원가입");   //B#4
                Console.WriteLine("about");     //A#8
                Console.WriteLine("자라"); // B#6
            }
            Console.WriteLine("article");
            {
                Console.WriteLine("본문이오"); //A#3
                Console.WriteLine("기사1");      // A#5
                Console.WriteLine("기사2");      // A#5

            }
            Console.WriteLine("footer");
            {
                Console.WriteLine("그레이엄 포터"); //A#3
            }
        }

    }
}