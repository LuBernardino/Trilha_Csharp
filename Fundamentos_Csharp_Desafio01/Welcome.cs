using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_Sharp;

class Welcome
{
    public static void Run()
    {
        Console.Write("Digite seu nome: ");

        string nome = Console.ReadLine();

        Console.WriteLine("Exercício 1: ");
        Console.WriteLine("Olá, " + nome + "! Seja muito bem-vindo(a)!");
        Console.WriteLine("------------------------------");

        Console.ReadKey();
    }
}
