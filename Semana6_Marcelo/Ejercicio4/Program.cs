// See https://aka.ms/new-console-template for more information

int compra, pagará, metodo, descuento;
String? día;

Console.WriteLine("Bienvenido al sistema de calculo de descuento");
Console.WriteLine("");
Console.Write("Ingrese el total a pagar C$ ");
compra = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Opciones:");
Console.WriteLine("1. Para tarjeta de crédito");
Console.WriteLine("2. Para Efectivo");

Console.Write("Ingrese el número de la opción adecuada: ");
metodo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

if (metodo != 1)
    Console.WriteLine("Gracias por visitarnos");

else
    if (metodo == 1)
{
    Console.Write("Ingrese el día de la compra (En Minúsculas): ");
    día = Convert.ToString(Console.ReadLine());

else
    if (día = "jueves")
{
    descuento = compra*0.4;
}


