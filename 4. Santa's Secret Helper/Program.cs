using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<string> good = new List<string>();
            while (input !="end")
            {
                StringBuilder sb = new StringBuilder();
                foreach (char item in input)
                {
                    sb.Append((char)(item - key));
                }

                string pattern = @"[^@!>:\-]*@(?<name>[A-Za-z]*)[^@!>:\-]*!(?<behavior>[A-Z]{1})!";
                //string secondpattern = @"[!](?<behavior>[A-Z]{1})[!]";
                Match matchname = Regex.Match(sb.ToString(), pattern);
                string name = matchname.Groups["name"].Value;
                string goodOrnot = matchname.Groups["behavior"].Value;

                if (goodOrnot=="G")
                {
                    good.Add(name);
                }
                input = Console.ReadLine();
            }

            foreach (var item in good)
            {
                Console.WriteLine(item);
            }
        }
    }
}
