// See https://aka.ms/new-console-template for more information

String? cod1="001", cod2="002", cod, salir="999";
int cont1=0, cont2=0, suma1=0, suma2=0, venta1, venta2;

inicio:

Console.Clear();

Console.WriteLine("Bienvenido al sistema de Ventas");
Console.WriteLine("Códigos disponibles:");

Console.WriteLine("001");
Console.WriteLine("002");
Console.WriteLine("999 - para salir");

Console.WriteLine("");

Console.Write("Ingrese el código de vendedor ");
cod = Console.ReadLine();

while (cod != salir)

{
    if (cod == cod1)
    {

        Console.WriteLine("Bienvenido Juan Pérez");

        Console.WriteLine("");

        Console.Write("Ingrese la cantidad de productos vendida: ");
        venta1 = Convert.ToInt32(Console.ReadLine());
        
        suma1 = venta1 + suma1;
        cont1=+1+cont1;

        goto inicio;

    }

    if (cod == cod2)
    {

        Console.WriteLine("Bienvenido María López");

        Console.WriteLine("");

        Console.Write("Ingrese la cantidad de productos vendida: ");
        venta2 = Convert.ToInt32(Console.ReadLine());
        
        suma2 = venta2 + suma2;
        cont2=+1+cont2;

        goto inicio;

    }
}

Console.Clear();

Console.WriteLine($"El primer vendedor realizó {cont1} ventas de productos y una cantidad de {suma1} productos");
Console.WriteLine($"El segundo vendedor realizó {cont2} ventas de productos y una cantidad de {suma2} productos");
