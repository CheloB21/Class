// See https://aka.ms/new-console-template for more information

//Escribe un programa que ingrese por teclado un número positivo de uno o dos dígitos (1…99) 
//mostrar un mensaje indicando si el número tiene uno o dos dígitos.

int num, digitos;

Console.Write("Ingrese un número entero: ");
num = Convert.ToInt32(Console.ReadLine());

digitos = (int)Math.Floor(Math.Log10(num) + 1);

if (digitos == 2)
    Console.WriteLine("El número posee 2 dígitos");
else
    Console.WriteLine("El número posee 1 dígito");
