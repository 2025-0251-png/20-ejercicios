using System.Collections.Concurrent;

Console.WriteLine("ingrese su salario mensual ");
int salario = int.Parse(Console.ReadLine());

string impuesto = salario switch
{
    < 10000 => " usted no paga impuestos 0%",
    > 10000 and < 30000 => " su impuestos a pagar son del 10%",
    > 30000 => "sus impuestos a pagar son del 20%",
};
Console.WriteLine(impuesto);
