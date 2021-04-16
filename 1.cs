using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(([w]{3})[.]([0-9a-z]{6})[.]([a-z]{3}))";//www.google.com
            string pattern1 = @"^(([w]{3})[.]([0-9a-z]{3})[.]([a-z]{2}))";//www.abc.by
            string pattern2 = @"^(([w]{3})[.]([0-9a-z]{7})[.]([a-z]{3}))";//www.youtube.com

            while (true)
            {
                Console.WriteLine("Введите адрес адрес");
                string adres = Console.ReadLine();

                if (Regex.IsMatch(adres, pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Адрес подтвержден");
                    break;
                }
                if (Regex.IsMatch(adres, pattern2, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Адрес подтвержден");
                    break;
                }
                if (Regex.IsMatch(adres, pattern1, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Адрес подтвержден");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный адрес");
                }
            }

        }
    }
}
