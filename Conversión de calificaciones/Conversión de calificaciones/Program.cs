Console.WriteLine("ingrese su calificacion");
int calificacion = int.Parse(Console.ReadLine());

string clasificacion = calificacion switch
{
    >= 90 and <= 100 => "A",
    >= 80 and <= 89 => "B",
    >= 70 and <= 79 => "C",
    >= 60 and <= 69 => "D",
    >= 0 and <= 59 => "F",
};
Console.WriteLine("Su calificacion es: " + clasificacion );