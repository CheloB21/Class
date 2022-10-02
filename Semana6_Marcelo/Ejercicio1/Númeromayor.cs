// See https://aka.ms/new-console-template for more information

int num1, num2, num3;

Console.WriteLine("Ingrese el primer número");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    if (num1>num3)
    {
        Console.WriteLine($"El mayor es {num1} y fue el primer número ingresado");
    }
    else
    {
        Console.WriteLine($"El mayor es {num3} y fue ingresado en el tercer lugar");
    }
} else

if (num2>num3)
{
    Console.WriteLine($"El mayor es {num2} y fue el segundo número ingresado");
}
else
{
    Console.WriteLine($"El mayor es {num3} y fue ingresado en tercer lugar");
}
