// See https://aka.ms/new-console-template for more information

int minutos;

Console.WriteLine("Ingrese los minutos");
minutos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(minutos + " minutos son " + Math.Truncate((double)minutos/60) + " horas y " + (minutos%60) + " minutos");
