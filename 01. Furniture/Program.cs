using System;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("Bought furniture:");
            string patern = @"^>>([A-Za-z]+)<<([0-9]+\.{0,1}[0-9]{0,})!([0-9]+)";
            decimal total = 0;
            while (input != "Purchase")
            {
                Match match = Regex.Match(input, patern);
                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string product = match.Groups[1].Value;
                decimal price = decimal.Parse(match.Groups[2].Value);
                int quontity = int.Parse(match.Groups[3].Value);
                total += price * quontity;

                Console.WriteLine(product);
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}