using System;

Console.WriteLine("ingrese su nombre");
string nombre = Console.ReadLine();

Console.WriteLine("ingrese su edad");
int edad = int.Parse(Console.ReadLine());

if (edad >= 60)
{
    Console.WriteLine($"señor/a {nombre} usted tiene un descuento del 50% en su entrada");
}
else if (edad < 60)
{
    Console.WriteLine($"señor/a {nombre} usted no aplica para el descuento");
}
