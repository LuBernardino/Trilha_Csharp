using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_Sharp;

class CompleteName
{
    public static void Run()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine("Exercício 2: ");
        Console.WriteLine("Nome completo: " + nome + " " + sobrenome);
        Console.WriteLine("------------------------------");

        Console.ReadKey();
    }
}
