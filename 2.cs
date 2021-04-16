using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(([А-Я])([а-я]*)[ ]([А-Я][.]{1}))";

            string[] FullNames = { "Лисовский Н.А.", "Середа Г.П.", "Пётр Пеьрович Иванов", "Иванов Иван Иванович" };




            for (int i = 0; i < FullNames.Length; i++)
            {

                if (Regex.IsMatch(FullNames[i], pattern, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine("Имя с совпадением по шаблону найдено" + " :" + FullNames[i]);

                }
            }



        }
    }
}
