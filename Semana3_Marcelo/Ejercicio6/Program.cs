// See https://aka.ms/new-console-template for more information

double lb, kg, gr;

Console.WriteLine("Ingrese libras");
lb = Convert.ToDouble(Console.ReadLine());

kg=lb*0.453592;
gr=lb*453.59237;

Console.WriteLine($"{lb:f2} Libras equivalen a {kg:f2} Kilogramos y {gr:f2} gramos");
