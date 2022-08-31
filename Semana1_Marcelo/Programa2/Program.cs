// See https://aka.ms/new-console-template for more information

//Un programa que solicite 4 números enteros, y que muestre la sumatoria, luego, 
//multiplicar el resultado de la sumatoria por 5.

Int32? num1, num2, num3, num4, suma, multiplicar; 

Console.Write("Ingrese el primer número > ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el Segundo número > ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el tercer número > ");
num3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el cuarto número > ");
num4 = Convert.ToInt32(Console.ReadLine());

suma=num1+num2+num3+num4;
multiplicar=suma*5;

Console.WriteLine("La sumatoria de los números ingresados es " +suma);
Console.WriteLine("La multiplicación por 5 del resultado es igual a "+multiplicar);
