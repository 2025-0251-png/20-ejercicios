Console.WriteLine("ingrese sus horas de turnos de 0-23");
int turnos = int.Parse(Console.ReadLine());

string clasificacion = turnos switch
{
    >= 6 and < 11 => "Turno de la mañana",
    >= 12 and < 17 => "Turno de la tarde",
    >= 18 and < 23 => "Turno de la noche",
    >= 0 and < 5 => "Turno de la madrugada",
};
Console.WriteLine(clasificacion);
