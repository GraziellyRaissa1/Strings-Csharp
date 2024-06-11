using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringCsharp
{
    internal class StringToUpperToLower
    {
        public static void Main(string[] args)
        {
            string texto = "Miau!";

            Console.WriteLine(texto.ToUpper()); //"MIAU!"

            Console.WriteLine(texto.ToLower()); //"Miau!"
        }
    }
}
