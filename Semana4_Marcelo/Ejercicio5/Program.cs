// See https://aka.ms/new-console-template for more information

double base1;
double altura;
double area;

Console.WriteLine("Introduzca la base: ");
base1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduzca la altura: ");
altura = Convert.ToDouble(Console.ReadLine());

area = (base1*altura)/2;

Console.WriteLine("Área del triángulo: " +area);
