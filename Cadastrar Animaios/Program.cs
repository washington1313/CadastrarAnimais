using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Animaios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animais = new string[6];
            
            Console.WriteLine("Digite o Nome do Animal: ");
            animais[0] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Nome do Animal: ");
            animais[1] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Nome do Animal: ");
            animais[2] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Nome do Animal: ");
            animais[3] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Nome do Animal: ");
            animais[4] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Nome do Animal: ");
            animais[5] = Console.ReadLine();
            Console.Clear();
                        
            Console.WriteLine("Animal 1: " + animais[0].ToUpper());
            Console.WriteLine("Animal 2: " + animais[1].ToUpper());
            Console.WriteLine("Animal 3: " + animais[2].ToUpper());
            Console.WriteLine("Animal 4: " + animais[3].ToUpper());
            Console.WriteLine("Animal 5: " + animais[4].ToUpper());
            Console.WriteLine("Animal 6: " + animais[5].ToUpper());

            Console.ReadKey();
        }
        
    }
}
