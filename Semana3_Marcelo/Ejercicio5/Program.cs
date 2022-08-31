// See https://aka.ms/new-console-template for more information

decimal distancia, velocidad, tiempo, costolit,
kilomlit, ltusado, costototal;

Console.WriteLine("");
Console.WriteLine("Calculo del tiempo y costo del viaje");

Console.Write("Por favor ingrese la distancia a recorrer en Kilometros: ");
distancia=Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("");

Console.Write("Por favor ingrese la velocidad promedio del recorrido en KM/h: ");
velocidad=Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("");

Console.Write("Por favor ingrese la cantidad de KM que recorre su vehiculo por litro de gasolina: ");
kilomlit=Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("");

Console.Write("Por favor ingrese el costo por litro de gasolina en C$: ");
costolit=Convert.ToDecimal(Console.ReadLine());

tiempo=distancia/velocidad;
ltusado=distancia/kilomlit;
costototal=ltusado*costolit;

Console.Clear();

Console.WriteLine("");

Console.WriteLine("Usted realizó un recorrido de: " +distancia+ " KM");
Console.WriteLine("En una velocidad promedio de " +velocidad+ " KM/h");
Console.WriteLine("Lo cual le tomó un tiempo de: " +tiempo+ " horas");
Console.WriteLine("");
Console.WriteLine("Su vehiculo tiene un rendimiento de "+kilomlit+ " KM/L");
Console.WriteLine("El litro de combustible esta a: C$ "+costolit); 
Console.WriteLine("Por lo tanto el costo estimado del viaje es de: "+costototal+ " Córdobas");
