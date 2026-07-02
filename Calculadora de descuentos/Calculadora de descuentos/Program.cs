Console.WriteLine("ingrese el precio del producto");
int producto = int.Parse(Console.ReadLine());

string clasificacion = producto switch
{
    <50 => "no tiene descuento",
    >=50 and <100 => "tiene un descuento del 5%",
    >100 => "tiene un descuento del 10%",
};
Console.WriteLine(clasificacion);
