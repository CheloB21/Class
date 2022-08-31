// See https://aka.ms/new-console-template for more information

String? nombre;
double salario, aumento=0.10, dineroau, neto;

Console.WriteLine("Bienvenido a la Empresa YOU CAN DO IT");
Console.WriteLine("Este sistema ayudará a calcular su aumento salarial");
Console.WriteLine("");

Console.WriteLine("Ingrese por favor su nombre");
nombre = Console.ReadLine();

Console.WriteLine("Ingrese su salario Actual");
salario = Convert.ToDouble(Console.ReadLine());

dineroau = salario*aumento;
neto = salario+dineroau;

Console.WriteLine("");
Console.WriteLine("SOMOS YOU CAN DO IT");
Console.WriteLine("Nombre: "+nombre);
Console.WriteLine("Salario: "+salario);
Console.WriteLine("Aumento: "+dineroau);
Console.WriteLine("Salario de Agosto: "+neto);
