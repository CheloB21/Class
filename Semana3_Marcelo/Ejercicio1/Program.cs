// See https://aka.ms/new-console-template for more information

decimal num1, num2, suma, promedio;

Console.WriteLine("Bienvenido, en este programa tendra que ingresar 2 números");
Console.WriteLine("De esta forma se calculará la suma y el promedio de dichos números");
Console.WriteLine("");

Console.WriteLine("Por favor, ingrese el primer número");
num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Por favor, ingrese el segundo número");
num2 = Convert.ToDecimal(Console.ReadLine());

suma=num1+num2;
promedio=suma/2;

Console.WriteLine($" Suma= {suma,9:f2} Promedio= {promedio,9:f2}");
