using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            Exercise5();
        }

        static void Exercise1()
        {
            int i = 0;
            Console.Write("Enter a series of number : ");
            var w = Console.ReadLine();
            var c = w.Split('-');
            int[] ch = Array.ConvertAll(c, int.Parse);
            int[] numAIn = Array.ConvertAll(c, int.Parse);
            Array.Sort(numAIn);
            var count = c.Length;
            if (numAIn[i] == ch[i])
            {
                foreach (var item in numAIn)
                {
                    if (item != ch[i])
                    {
                        Console.WriteLine("Not Consecutive");
                        Environment.Exit(0);
                    }
                    i++;
                }
                Console.WriteLine("Consecutive");
            }
            else if (numAIn[i] == ch[count - 1])
            {
                foreach (var item in numAIn)
                {
                    if (item != ch[count - 1])
                    {
                        Console.WriteLine("Not Consecutive");
                        Environment.Exit(0);
                    }
                    count--;
                }
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
                Environment.Exit(0);
            }



        }

        static void Exercise2()
        {
            Console.Write("Enter a series of number : ");
            var w = Console.ReadLine();
            var c = w.Split(',');
            for (int i = 1; i < c.Length; i++)
            {
                if (c[0] == c[i])
                {
                    Console.WriteLine("Duplicate");
                    Environment.Exit(0);
                } 
            }
            Console.WriteLine("OK");

        }

        static void Exercise3()
        {
            Console.Write("Enter a time value in the 24-hour  : ");
            var t = Console.ReadLine();
            var time = t.Split(':');
            int[] timeAIn = Array.ConvertAll(time, int.Parse);
            if (timeAIn[0]< 24)
            {
                if (timeAIn[1] < 60)
                {
                    Console.WriteLine("OK");
                }
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }

        }

        static void Exercise4()
        {
            Console.Write("Enter a few words: ");
            var w = Console.ReadLine();
            var vName = "";
            if (String.IsNullOrWhiteSpace(w))
            {
                Console.WriteLine("Error");
                return;
            }
            
            foreach (var item in w.Split(' '))
            {
                var PascalCase = char.ToUpper(item[0]) + item.ToLower().Substring(1);
                vName += PascalCase;
            }

            Console.WriteLine(vName);
        }

        static void Exercise5()
        {
            var count = 0;
            //var vowels = new string[]{"a","e","o","u","i"};
            var vowels = "aeoui";
            Console.Write("Enter an English word: ");
            var w = Console.ReadLine();

            foreach (var item in w)
            {
                foreach (var itemV in vowels)
                {
                    if (item == itemV)
                    {
                        count += 1;
                    }
                }
            }
            Console.WriteLine(count);
        }





    }
}
