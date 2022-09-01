// See https://aka.ms/new-console-template for more information

double num1, num2, num3, num4, suma, prom;

Console.WriteLine("Ingrese el número 1:");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el número 2:");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el número 3:");
num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese el número 4:");
num4 = Convert.ToDouble(Console.ReadLine());

suma = num1 + num2 + num3 + num4;
prom = suma/4;

Console.WriteLine("La suma de los 4 números es: "+suma);
Console.WriteLine("El promedio de los números es: "+prom);
