Console.WriteLine("ingrese primer numero");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese segundo numero");

int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese tercer numero");

int num3 = int.Parse(Console.ReadLine());

if (num1 > 0 & num2 > 0 & num3 > 0)
{
    Console.WriteLine("todos los numeros son positivos");
}

else if (num1 < 0 & num2 < 0 & num3 < 0)
{
    Console.WriteLine("todos los numeros son negativos");
}
else if (num1 == 0 & num2 == 0 & num3 == 0)
{
    Console.WriteLine("hay almenos un 0");
}
else
{
    Console.WriteLine("son mixtos");
}