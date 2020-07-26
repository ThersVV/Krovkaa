using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Krovka
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Kvadraticko-Rovnico-Kalkulátor, aka Krovka, k vašim službám!");
            Code();
        }
        static void Code()
        {

            try
            {
                Console.WriteLine("Kolik je a? ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kolik je b? ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kolik je c? ");
                double num3 = Convert.ToDouble(Console.ReadLine());
                double disk = Disk(num1, num2, num3);
                if (disk >= 0)
                {
                    double ix = Kvad1(num1, num2, disk);
                    double yy = Kvad2(num1, num2, disk);
                    if (ix == yy)
                    {
                        Console.WriteLine("x=" + ix);
                    }
                    else
                    {
                        Console.WriteLine("x1=" + ix + "         x2=" + yy);
                    }
                }
                else
                {
                    Console.WriteLine("Nemá řešení, diskriminant je menší než nula.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Zadejte platné číslo");
                Code();
            }

            Console.ReadKey();
        }
        static double Disk(double num1, double num2, double num3)
        {
            double Barman = ((num2 * num2) - (4 * num1 * num3));
            return Barman;
        }
        static double Kvad1(double num1, double num2, double disk) 
        {
            return (((num2 * (-1) - Math.Sqrt(disk)) / (2 * num1)));
        }
        static double Kvad2(double num1, double num2, double disk)
        {
            return (((num2 * (-1) + Math.Sqrt(disk)) / (2 * num1)));
        }
    }
}
