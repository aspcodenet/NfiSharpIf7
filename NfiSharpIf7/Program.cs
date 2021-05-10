using System;
using System.Collections.Generic;

namespace NfiSharpIf7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv in ditt land");
            var land = Console.ReadLine();


            

            if (land == "Sverige")
            {
                Console.WriteLine("Du bor i Skandinavien");
            }
            else if (land == "Norge")
            {
                Console.WriteLine("Du bor i Skandinavien");
            }
            else if (land == "Danmark")
            {
                Console.WriteLine("Du bor i Skandinavien");
            }
            else
                Console.WriteLine("Du bor INTE i Skandinavien");



            if (land == "Sverige" || land == "Danmark" || land == "Norge")
            {
                Console.WriteLine("Du bor i Skandinavien");
            }
            else
                Console.WriteLine("Du bor INTE i Skandinavien");
        }
    }
}
