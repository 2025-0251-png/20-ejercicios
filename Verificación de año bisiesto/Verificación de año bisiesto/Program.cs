Console.Write("Ingresa un año: ");
int año = int.Parse(Console.ReadLine());

if (año % 400 == 0)
{
    Console.WriteLine($"{año} es bisiesto");
}
else if (año % 100 == 0)
{
    Console.WriteLine($"{año} no es bisiesto");
}
else if (año % 4 == 0)
{
    Console.WriteLine($"{año} es bisiesto");
}
else
{
    Console.WriteLine($"{año} no es bisiesto");
}
