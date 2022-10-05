// See https://aka.ms/new-console-template for more information

String? nombres="0", fin="salir";
Int32 cont=0;

while (nombres != fin )

{

Console.WriteLine("Ingrese un nombre (Use minusculas)");
nombres = Console.ReadLine();

cont=+1+cont;

}

Console.Clear();
Console.WriteLine($"Usted ingresó {cont} nombres antes de ingresar la palabra salir");
