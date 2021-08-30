using System;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split("|");
            //
            //string firstPart = input[0];
            //string secondPart = input[1];
            //string thirdPart = input[2];
            //
            //string firstPattern = @"([#$%*&])(?<capitals>[A-Z]+)(\1)";
            //Match firstMatch = Regex.Match(firstPart, firstPattern);
            //string capitals = firstMatch.Groups["capitals"].Value;
            //
            //for (int index = 0; index < capitals.Length; index++)
            //{
            //    char startLetter = capitals[index];
            //    int ASCIIcode = startLetter;
            //
            //    string secondPattern = $@"{ASCIIcode}:(?<length>[0-9][0-9])";
            //    Match secondMatch = Regex.Match(secondPart, secondPattern);
            //    int length = int.Parse(secondMatch.Groups["length"].Value);
            //
            //    string thirdPattern = $@"(?<=\s|^){startLetter}[^\s]{{{length}}}(?=\s|$)";
            //    Match thirdMatch = Regex.Match(thirdPart, thirdPattern);
            //    string word = thirdMatch.ToString();
            //
            //    Console.WriteLine(word);
            //}

            string first = @"([$])(?<word>[A-Z]+)(\1)";

            string[] input = Console.ReadLine().Split("|");

            string firstword = input[0];
            string numberOfLeter = input[1];
            string words = input[2];
            Match matchupword = Regex.Match(firstword, first);
            string machefir = matchupword.Groups["word"].Value;

            for (int i = 0; i < matchupword.Length-1; i++)
            {
                char strtet =machefir[i] ;
                int startleter = strtet;

                string paterndigit = $@"({startleter}):(?<length>[0-9][0-9])";
                Match secondmatch = Regex.Match(numberOfLeter, paterndigit);
                int lenght = int.Parse(secondmatch.Groups["length"].Value);

                string paternOfword = $@"(?<=\s|^){strtet}[^\s]{{{lenght}}}(?=\s|$)";
                Match thirdmath = Regex.Match(words, paternOfword);
                string machesword = thirdmath.ToString();

                Console.WriteLine(machesword);
            }


        }
    }
}