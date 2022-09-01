// See https://aka.ms/new-console-template for more information

double gradosc, gradosf;

Console.WriteLine("Ingrese los grados en Fahrenheit:");
gradosf = Convert.ToDouble(Console.ReadLine());

gradosc = (gradosf-32)*5/9;

Console.WriteLine("La cantidad de grados Farenheit en Celsius es: " +gradosc);
