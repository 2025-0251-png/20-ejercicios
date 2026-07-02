Console.Write("Ingresa tu peso en kg: ");
double peso = double.Parse(Console.ReadLine());

Console.Write("Ingresa tu altura en m: ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine($"Tu IMC es: {imc:F2}");

if (imc < 18.5)
{
    Console.WriteLine("Clasificacion bajo peso");
}
else if (imc <= 24.9)
{
    Console.WriteLine("Clasificacin normal");
}
else if (imc <= 29.9)
{
    Console.WriteLine("Clasificacin sobrepeso");
}
else
{
    Console.WriteLine("Clasificacin obesidad");
}