using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        public static int option = 0;
        public static string side1 = "0";
        public static string side2 = "0";
        public static string side3 = "0";
        public static decimal Side1 = 0;
        public static decimal Side2 = 0;
        public static decimal Side3 = 0;

        public static void Menu()
        {
            for (; ; )
            {
                Console.WriteLine("Please select one of the option!");
                Console.WriteLine("1: Enter triangle dimensions");
                Console.WriteLine("2: Exit");
                try
                {
                    string stroption = Console.ReadLine();
                    option = int.Parse(stroption);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please input correct integer");
                    Menu();
                }
                if (option == 1 || option == 2)
                {
                    break;
                }
            }
        }
        public static void Sides1()
        {
            Console.WriteLine("Lenght of 1st side");
            try
            {
                side1 = Console.ReadLine();
                Side1 = decimal.Parse(side1);
                if (Side1 <= 0)
                {
                    Console.WriteLine("Please, Enter Positive integer Values");
                    Sides1();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please input correct integer");
                Sides1();
            }
        }
        public static void Sides2()
        {
            Console.WriteLine("Lenght of 2nd side");
            try
            {
                side2 = Console.ReadLine();
                Side2 = decimal.Parse(side2);
                if (Side2 <= 0)
                {
                    Console.WriteLine("Please, Enter Positive integer Values");
                    Sides2();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please input correct integer");
                Sides2();
            }
        }
        public static void Sides3()
        {
            Console.WriteLine("Lenght of 3rd side");
            try
            {
                side3 = Console.ReadLine();
                Side3 = decimal.Parse(side3);
                if (Side3 <= 0)
                {
                    Console.WriteLine("Please, Enter Positive integer Values!");
                    Sides3();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please input correct integer");
                Sides3();
            }
        }

        static void Main(string[] args)
        {
            Menu();
            if (option == 1)
            {
                Sides1();
                Sides2();
                Sides3();
                if ((Side1 + Side2 > Side3) && (Side2 + Side3 > Side1) && (Side1 + Side3 > Side2))
                {
                    Console.WriteLine("Yes they form a triangle");
                    TriangleSolver.Analyse(Side1, Side2, Side3);
                    Console.WriteLine("Thanks!! Have a Great Day!!");
                }
                else
                {
                    Console.WriteLine("They Dont form a triangle");
                }
                Console.ReadLine();
            }
            else if (option == 2)
            { System.Environment.Exit(0); }
            Console.ReadLine();
        }
    }
}
