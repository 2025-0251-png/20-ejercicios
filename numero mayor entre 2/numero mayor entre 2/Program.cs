Console.WriteLine("ingrese primer numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese segundo numero");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("El numero mayor es: " + num1);
}
else if (num2 > num1)
{
    Console.WriteLine("El numero mayor es: " + num2);
}
else
{
    Console.WriteLine("Los numeros son iguales");
}
