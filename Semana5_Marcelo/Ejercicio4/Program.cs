// See https://aka.ms/new-console-template for more information

int num;

Console.Write("Por favor ingrese un número: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

if ((num%2)==0)
    Console.WriteLine("El número ingresado es par");
else
    Console.WriteLine("El número ingresado es impar");
