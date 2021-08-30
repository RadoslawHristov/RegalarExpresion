using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"^%([A-Za-z]+)%[^|$%.]<(\w+)>[^|$%.]*\|[^|%$.].?([+-]?[0-9]*\.?[0-9]+([eE][+-]?[0-9]+)?)\$";
            //string patern = @"%([A-Za-z]+)%<([A-Za-z]+)>\|([(0-9]{0,})\|([0-9]{0,}\.[0-9])\$";
            double total = 0;
            while (input != "end of shift")
            {
                Match matches = Regex.Match(input, patern);
                if (matches.Success)
                {
                    string name = matches.Groups[1].Value;
                    string product = matches.Groups[2].Value;
                    double quantity = double.Parse(matches.Groups[3].Value);
                    double price = double.Parse(matches.Groups[4].Value);
                    double midtot = quantity * price;
                    total += quantity * price;
                    Console.WriteLine($"{name}: {product} - {midtot:f2}");
                    input = Console.ReadLine();
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
