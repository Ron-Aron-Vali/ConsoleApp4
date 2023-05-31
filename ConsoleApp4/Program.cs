using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace TakeWhile
{
    internal class Program
    {
        private static string wrightPath = "C:/Users/opilane/Desktop/fileToDesktop.txt";
        private static string wrongPath = "V:/Users/opilane/FileToDesktop.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("1. TakeWhile");
            Console.WriteLine("2. Except");
            Console.WriteLine("3. ForLoop");
            Console.WriteLine("4. Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    TakeWhile();
                    break;

                case 2:
                    Except();
                    break;

                case 3:
                    ForLoop();
                    break;

                case 4:
                    Õige();
                    break;

                case 5:
                    Vale();
                    break;


            }
        }
        public static void TakeWhile()
        {
            List<int> numbers = new List<int> { 9, 5, 3, 4, 2, 6, 7, 8, 1, 10 };

            Console.WriteLine("Kirjuta number 1, et korrastada list");
            int filteredNumber = int.Parse(Console.ReadLine());

            IEnumerable<int> filteredNumbers = numbers.TakeWhile(num => num != filteredNumber);

            Console.WriteLine("\nKorrastatud numbrid: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
            foreach (int number in filteredNumbers)
            {
                Console.WriteLine(number);
            }

        }
        public static void Except()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

            var result = strList1.Except(strList2);

            foreach (var item in result)
            {
                Console.WriteLine("Except: " + item);
            }
        }
        public static void ForLoop()
        {
            {
                int i, j, rows;

                Console.WriteLine("Numbri püramiid");

                Console.WriteLine("Sisesta ridade arv");

                rows = Convert.ToInt32(Console.ReadLine());


                for (i = 0; i <= rows; i++)
                {
                    for (j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        //Console.Write("{0} ", t++);
                        Console.Write("*"); //kui paned selle, siis saad püramiidi
                    }
                    Console.Write("\n");
                }

                for (i = rows - 1; i >= 1; i--)
                {
                    for (j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
        }
        public static void Õige()
        {
            
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void Vale()
        {
            
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }

            int choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
