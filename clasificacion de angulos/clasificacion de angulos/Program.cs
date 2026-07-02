Console.WriteLine("ingrese el valor del angulo en grados");
int angulo = int.Parse(Console.ReadLine());

string clasificacion = angulo switch
{
    < 0 or >180 => "angulo invalido",
    < 90   => "angulo agudo",
      90   => "angulo recto",
    < 180 => "angulo Obtuso",
    180 => "angulo llano",

};
Console.WriteLine($"el angulo de {angulo} grados es un angulo {clasificacion}");