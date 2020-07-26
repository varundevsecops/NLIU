using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ViewStateDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the viewstate in ViewStateDecoder");
            string str = Console.ReadLine();
            Console.WriteLine("Decoding using ViewStateDecoder");
            Thread.Sleep(10000);
            string str1=System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(str));
            Console.WriteLine(str1);
            Console.Read();
        }
    }
}
