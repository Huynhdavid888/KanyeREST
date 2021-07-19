using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("-------------------");
                QuoteGenerator.KanyeQuote();
                QuoteGenerator.RonQuote();
            }




        }
    }
}
