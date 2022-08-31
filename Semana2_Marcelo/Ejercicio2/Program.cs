// See https://aka.ms/new-console-template for more information

int num1, num2, num3;

Console.WriteLine("Bienvenido, por favor ingrese 3 Números");
Console.WriteLine("");

Console.Write("Ingrese el Primer Número: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el Segundo Número: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el tercer Número: ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("La media de los tres números es: " + ((num1+num2+num3)/3));
