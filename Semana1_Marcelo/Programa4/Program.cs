// See https://aka.ms/new-console-template for more information

//Convertir de dólares a córdobas, utilizando tipo de datos Double. 

double Dolar, cordoba=36, multiplicar;


Console.WriteLine("Ingrese la cantidad de dolares a convertir");
Dolar=Convert.ToDouble(Console.ReadLine());

multiplicar=Dolar*cordoba;

Console.WriteLine("Usted va a recibir la cantidad de C$ " +multiplicar);
