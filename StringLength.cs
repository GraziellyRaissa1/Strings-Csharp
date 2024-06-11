using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;


//Uma string em C# é na verdade um objeto que contém propriedades e métodos que podem executar certas operações em strings. Por exemplo, o comprimento de uma string pode ser encontrado com a Length


namespace StringCsharp
{
    internal class StringLength
    {
        public static void Main(string[] args)
        {
            string texto = "ADSFSHSFJDFJFGJFKFJ";

            Console.WriteLine("O comprimento dessa string é: "  + texto.Length);
        }
    }
}
