// See https://aka.ms/new-console-template for more information

double dinero, dolar=36, cambio;

Console.WriteLine("Ingrese el dinero en córdobas: ");
dinero = Convert.ToDouble(Console.ReadLine());

cambio = dinero/dolar;

Console.WriteLine("La cantida de dinero en C$ "+dinero+ " es equivalente a $ " +cambio);
