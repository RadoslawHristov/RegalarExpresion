using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            //string pattern = @"([A-Za-z0-9][#@$^]{6,})*[A-za-z0-9]*([$@#^]{6,}|[$@#^]*)";
            List<string> ticket = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> match = new List<string>();
            List<string> nomatch = new List<string>();

            string fulltickrt = @"([#@$^]+)";
            for (int i = 0; i < ticket.Count; i++)
            {
                Match matches = Regex.Match(ticket[i], fulltickrt);
                if (matches.Success)
                {
                    match.Add(ticket[i]);
                }
                else
                {
                    nomatch.Add(ticket[i]);
                }
            }

            foreach (var item in match)
            {
                Console.WriteLine(item);
            }

            foreach (var item in nomatch)
            {
                Console.WriteLine(item);
            }


        }
    }
}
