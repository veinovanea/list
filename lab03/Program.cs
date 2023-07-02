using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Program
    {    // задача №30
        static void Main(string[] args)
        {
            int n, a, b, c; string s1=" ", s2=" ", s3=" ", str;
            Console.WriteLine("Введите число: "); 
            n = Convert.ToInt32(Console.ReadLine());
            a = n / 100;
            b = n % 100 / 10;
            c = n % 100 % 10;
            if (n < 1 || n > 999)
            { Console.WriteLine("Error!"); }
            else
            {
                if (a == 0)
                    s1 = "";
                if (a == 1)
                    s1 = "сто";
                if (a == 2)
                    s1 = "двести";
                if (a == 3)
                    s1 = "триста";
                if (a == 4)
                    s1 = "четиреста";
                if (a == 5)
                    s1 = "пятьсот";
                if (a == 6)
                    s1 = "шестьсот";
                if (a == 7)
                    s1 = "семьсот";
                if (a == 8)
                    s1 = "восемьсот";
                if (a == 9)
                    s1 = "девятьсот";
                // вторая позиция
                if (b == 0)
                    s2 = "";
                if (b == 2)
                    s2 = "двадцать";
                if (b == 3)
                    s2 = "тридцать";
                if (b == 4)
                    s2 = "сорок";
                if (b == 5)
                    s2 = "пятьдесят";
                if (b == 6)
                    s2 = "шестьдесят";
                if (b == 7)
                    s2 = "семьдесят";
                if (b == 8)
                    s2 = "восемьдесят";
                if (b == 9)
                    s2 = "девяносто";
                if (n % 100 > 9 && n % 100 < 20)
                {
                    if (c == 0)
                    { s2 = "десять"; s3 = ""; }
                    if (c == 1)
                    { s2 = "одинадцать"; s3 = ""; }
                    if (c == 2)
                    { s2 = "двенадцать"; s3 = ""; }
                    if (c == 3)
                    { s2 = "тринадцать"; s3 = ""; }
                    if (c == 4)
                    { s2 = "четирнадцать"; s3 = ""; }
                    if (c == 5)
                    { s2 = "пятнадцать"; s3 = ""; }
                    if (c == 6)
                    { s2 = "шестнадцать"; s3 = ""; }
                    if (c == 7)
                    { s2 = "семьнадцать"; s3 = ""; }
                    if (c == 8)
                    { s2 = "восемьнадцать"; s3 = ""; }
                    if (c == 9)
                    { s2 = "девятнадцать"; s3 = ""; }
                }
                // третья
                else
                {
                    if (c == 0)
                        s3 = "";
                    if (c == 1)
                        s3 = "один";
                    if (c == 2)
                        s3 = "два";
                    if (c == 3)
                        s3 = "три";
                    if (c == 4)
                        s3 = "четире";
                    if (c == 5)
                        s3 = "пять";
                    if (c == 6)
                        s3 = "шесть";
                    if (c == 7)
                        s3 = "семь";
                    if (c == 8)
                        s3 = "восемь";
                    if (c == 9)
                        s3 = "девять";
                }
            }
            str = s1 + " " + s2 + " " + s3;
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
