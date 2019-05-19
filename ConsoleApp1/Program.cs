using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CurrencyFormatConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

                Console.WriteLine("Please write your 1st dollar amount: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Please write your 2nd dollar amount: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Please write your 3rd dollar amount: ");
                c = double.Parse(Console.ReadLine());
                double average = (a + b + c) / 3;
                Console.WriteLine("The average sum of these 3 numbers is =" + average);
                double total = (a + b + c);
                Console.WriteLine("The total sum of these 3 numbers is =" + total);
                if (a < b && a < c)
                {
                    Console.WriteLine("The smallest number is: {0}", a);
                }
                else if (b < a && b < c)
                {
                    Console.WriteLine("The smallest number is: {0}", b);
                }
                else
                {
                    Console.WriteLine("The smallest number is: {0}", c);
                }
                if (a > b && a > c)
                {
                    Console.WriteLine("The biggest number is: {0}", a);
                }
                else if (b > a && b > c)
                {
                    Console.WriteLine("The biggest number is: {0}", b);
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", c);
                }


                Console.WriteLine(total.ToString("C2", CultureInfo.CurrentCulture));
                Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("sma-SE")));
                Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
                Console.WriteLine(total.ToString("C2", CultureInfo.CreateSpecificCulture("thb-THB")));
                Console.ReadLine();
        }






        
    }
}

