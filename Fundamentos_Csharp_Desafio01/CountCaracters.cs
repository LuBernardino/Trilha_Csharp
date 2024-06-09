using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_Sharp;

class CountCaracters
{
    public static void Run()
    {
        Console.Write("Digite um lugar favorito: ");
        string place = Console.ReadLine();

        var caracters = place.Length;
        Console.WriteLine("Exercício 4: ");
        Console.WriteLine("O texto contém " + caracters + " caracteres");
        Console.WriteLine("------------------------------");
    }
}