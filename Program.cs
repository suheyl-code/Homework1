using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10April
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tcString = Prompt("TC Numara Girin: ");
            
            if (CheckNotEmpty(tcString) && CheckIsDigit(tcString) && CheckIdCard(tcString))
            {
                Console.WriteLine("Doğru TC Numarası.");
            }
            else
            {
                Console.WriteLine("Hata var. Tekrar deneyiniz!");
            }
        }

        /// <summary>
        /// kullanıcıya bir mesaj gönderir ve kullanıcı girişi geri döner. 
        /// </summary>
        /// <param name="message"></param>
        /// <returns>string</returns>
        static string Prompt(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// kullanıcının boş girmediğini kontrol ediyor.
        /// </summary>
        /// <param name="tc"></param>
        /// <returns>true/false</returns>
        static bool CheckNotEmpty(string tc)
        {
            if (!string.IsNullOrEmpty(tc))
            {
                return true;
            }
            Console.WriteLine("Kimlik numarası boş değil.");
            return false;
        }

        /// <summary>
        /// Kullanıcı rakamlar girdiği kontrol ediyor.
        /// </summary>
        /// <param name="tc"></param>
        /// <returns>true/false</returns>
        static bool CheckIsDigit(string tc)
        {
            bool check = long.TryParse(tc, out long number);
            if (check)
            {
                return true;
            }
            Console.WriteLine("Doğru kimilik numarası yaziniz! Kimilik numarasına alfabe dahel değildir.");
            return false;
        }

        /// <summary>
        /// Kullanıcı 11 haneli ve 0'den başlamadan bir numarası yazdığı kontrol ediyor.
        /// </summary>
        /// <param name="tc"></param>
        /// <returns>true/false</returns>
        static bool CheckIdCard(string tc)
        {
            if (tc.Length == 11)
            {
                for (int i = 0; i < tc.Length; i++)
                {
                    if (tc[i] == '0' && i == 0)
                    {
                        Console.WriteLine("TC numarası 0 ile başlamaz.");
                        return false;
                    }
                    else if (tc[i] == '9' && i == 0)
                    {
                        Console.WriteLine("Yabancı TC Kimilik numarası.");
                    }
                }
                return true;
            }
            Console.WriteLine("11 haneli TC kimlik numaranızı giriniz.");
            return false;
        }
    }
}