// See https://aka.ms/new-console-template for more information

double precioUnidad, cantidad, IVA, precioSinIva, totalIva;

Console.WriteLine("Introduzca precio por unidad del producto: ");
precioUnidad = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduzca número de productos vendidos: ");
cantidad = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduzca %IVA: ");
IVA = Convert.ToDouble(Console.ReadLine());

precioSinIva = precioUnidad * cantidad;
totalIva = (precioSinIva*IVA/100)+precioSinIva;

Console.WriteLine("Los productos tienen un precio sin IVA de: C$ "+precioSinIva);
Console.WriteLine("El IVA a aplicar es de: "+IVA+ " %");
Console.WriteLine("Usted va a pagar: C$"+totalIva+ " Netos.");
