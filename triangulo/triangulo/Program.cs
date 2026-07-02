Console.Write("Lado a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Lado b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Lado c: ");
double c = double.Parse(Console.ReadLine());

if (a == b & b == c)
{
    Console.WriteLine("El triángulo es Equilátero");
}
else if (a == b || b == c || a == c)
{
    Console.WriteLine("El triángulo es Isósceles");
}
else
{
    Console.WriteLine("El triángulo es Escaleno");
}
