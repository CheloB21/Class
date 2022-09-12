// See https://aka.ms/new-console-template for more information

//Escribe un programa en que el usuario ingrese el sueldo de una persona, 
//si supera los 4000 córdobas mostrar un mensaje en pantalla indicando que debe abonar impuestos.

int salario;

Console.Write("Ingrese su salario sin espacios ni signos de puntuación: C$ ");
salario = Convert.ToInt32(Console.ReadLine());

if (salario>4000)
    Console.WriteLine("Usted debe abonar impuestos");
