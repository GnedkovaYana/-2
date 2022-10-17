using System;
using System.Globalization;
namespace ex2
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            if (IntNum(number))
            {
                Console.WriteLine("Число коректно: " + "сумма цифр: " + Summ(number));
            }
            else
            {
                Console.WriteLine("Число не коректно");
                return;
            }
        }

        public static bool IntNum(string str)
        {
            string numbers = "0123456789";
            if (str[0] == '-')
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (numbers.Contains(str[i].ToString()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (str[0] != '-')
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (numbers.Contains(str[i].ToString()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int Summ(string str)
        {
            int sum = 0;
            if (str[0] == '-')
            {
                for (int i = 1; i < str.Length; i++)
                    sum += str[i] - '0';
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                    sum += str[i] - '0';
            }
            return sum;
        }
    }
}