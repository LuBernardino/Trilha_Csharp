using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_Sharp;

class VerifyPlate
{
    public static void Run()
    {
        Console.WriteLine("Digite a placa do veículo:");
        string plate = Console.ReadLine();

        Console.WriteLine("Exercício 5: ");
        if (plate.Length != 7)
        {
            Console.WriteLine("Esta número NÃO é VÁLIDO");
            Console.WriteLine("------------------------------");
            return;
        }

        if (!char.IsLetter(plate[0]) || !char.IsLetter(plate[1]) || !char.IsLetter(plate[2]))
        {
            Console.WriteLine("Esta número NÃO é VÁLIDO");
            Console.WriteLine("------------------------------");
            return;
        }

        if (!char.IsDigit(plate[3]) || !char.IsDigit(plate[4]) || !char.IsDigit(plate[5]) || !char.IsDigit(plate[6]))
        {
            Console.WriteLine("Esta número NÃO é VÁLIDO");
            Console.WriteLine("------------------------------");
            return;
        }

        Console.WriteLine("Esta número de placa é VÁLIDO");
        Console.WriteLine("------------------------------");
    }
}
