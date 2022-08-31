// See https://aka.ms/new-console-template for more information

decimal yardas, pulgadas = 36, total;

Console.Write("Por favor ingrese la cantidad de Yardas a Convertir: ");
yardas = Convert.ToDecimal(Console.ReadLine());

total=yardas*pulgadas;

Console.WriteLine(+yardas+ " Yardas son "+total+ " Pulgadas.");
