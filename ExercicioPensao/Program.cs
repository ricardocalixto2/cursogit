using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPensao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Quarto.Calcula(ref a);
            Console.WriteLine(a);
            Console.WriteLine("Bom dia");
            Console.WriteLine("Olá");
        }
    }
}
