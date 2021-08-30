using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"\+359(\-|\ )2\1\d{3}\1\d{4}\b";//@"[0-9][0-9]+)(\s[0-9]{1}\s[0-9]{3})\s([0-9]{4})|\+([0-9][0-9]+)(-[0-9]{1}-[0-9]{3})-([0-9]{4})";
            var machnumbert = Regex.Matches(input, patern);
            var result = machnumbert.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", result));
                                          
        }
    }
}
