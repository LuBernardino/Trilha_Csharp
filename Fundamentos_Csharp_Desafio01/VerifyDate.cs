using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_Sharp;

class VerifyDate
{
    public static void Run()
    {
        DateTime agora = DateTime.Now;

        Console.WriteLine("Exercício 6: ");
        Console.WriteLine("Formato completo:");
        Console.WriteLine(agora.ToString("dddd, dd/MM/yyyy HH:mm:ss"));

        Console.WriteLine("\nApenas a data:");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));

        Console.WriteLine("\nApenas a hora (formato de 24 horas):");
        Console.WriteLine(agora.ToString("HH:mm:ss"));

        Console.WriteLine("\nData com o mês por extenso:");
        CultureInfo culturaBrasil = new CultureInfo("pt-BR");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", culturaBrasil));
        Console.WriteLine("------------------------------");
    }
}
