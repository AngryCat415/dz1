using System;
namespace ConsoleApp1
{
    class program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введте ваше имя");
            //string name = Console.ReadLine();
            //Console.WriteLine("Здравстувуйте, " + name + "!");


            //int a = 3;
            //int b = 5;
            //Console.WriteLine(a+b);


            //int a = 8;
            //int b = 9;
            //if (a > b) {
            //Console.WriteLine( a-b); 
            //}

            //else
            //{
            //    Console.WriteLine(b-a);
            //}


            //Console.WriteLine("Сколько вам лет?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Вы прожили: " + age + " год(а)/лет");


            //Console.WriteLine("Введите число от -2147483648 до 2147483647");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num<0)
            //{
            //    Console.WriteLine("Число отрицательное");
            //}
            //else
            //{
            //    Console.WriteLine("Число положительное");
            //}


            int a = 4;
            int b = 6;
            if (a != b)
            {
                a = a + b;
                b = a;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                a = 0;
                b = 0;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }


            Console.ReadLine();
        }
    }
}