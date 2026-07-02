Console.WriteLine("ingrese primer longitud");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese segunda longitud");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese tercera longitud");
int num3 = int.Parse(Console.ReadLine());

if (num1+ num2 > num3 && num1 + num3 > num2 && num2 + num3 > num1)
{
    Console.WriteLine("las longitudes ingresadas pueden formar un triangulo");
}
else
{
    Console.WriteLine("las longitudes ingresadas no pueden formar un triangulo");
}
