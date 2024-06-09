using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_C_Sharp;

public class OperationsResult
{
    public double AddResult { get; set; }
    public double SubResult { get; set; }
    public double MultiResult { get; set; }
    public double DivResult { get; set; }
    public double RestResult { get; set; }
}
public class OperationsMath
{
    public OperationsResult Add(double valor1, double valor2)
    {
        var add = valor1 + valor2;
        var sub = valor1 - valor2;
        var multi = valor1 * valor2;
        var div = valor1 / valor2;
        var rest = (valor1 + valor2) / 2;

        var result = new OperationsResult
        {
            AddResult = add,
            SubResult = sub,
            MultiResult = multi,
            DivResult = div,
            RestResult = rest
        };

        return result;
    }
}

class Calculator
{
    public static void Run()
    {
        var operation = new OperationsMath();

        var result = operation.Add(10, 1);

        Console.WriteLine("Exercício 3: ");
        Console.WriteLine($"Add: {result.AddResult}");
        Console.WriteLine($"Sub: {result.SubResult}");
        Console.WriteLine($"Multi: {result.MultiResult}");
        Console.WriteLine($"Div: {result.DivResult}");
        Console.WriteLine($"Rest: {result.RestResult}");
        Console.WriteLine("------------------------------");
    }
}