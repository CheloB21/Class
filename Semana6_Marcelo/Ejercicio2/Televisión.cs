// See https://aka.ms/new-console-template for more information

Int32 plan, costo, extras, numtel, total;

Console.WriteLine("Bienvenido al servicio de televisión por cable");
Console.WriteLine("");

Console.WriteLine("Estos son los planes que tenemos disponibles para usted");
Console.WriteLine("");

Console.WriteLine("1 - Paquete básico C$ 150.00 (Un solo televisor)");
Console.WriteLine("2 - Paquete intermedio C$ 250.00 (Tres Televisores)");
Console.WriteLine("3 - Paquete familiar C$ 500.00 (Cinco televisores)");
Console.WriteLine("4 - Paquete Premium C$ 900.00 (10 televisores)");
Console.WriteLine("Puede agregar televisores extras a su plan con un valor de C$100.00");
Console.WriteLine("");

Console.Write("Ingrese el número del plan de su preferencia: ");
plan = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el número de televisores extras que desea (En caso de no querer extras escribir 0): ");
numtel = Convert.ToInt32(Console.ReadLine());

extras = numtel*100;

if (plan==1)
{
    costo=150;
    Console.WriteLine("Usted ha seleccionado el plan básico con un costo de C$ "+costo);
    if (numtel!=0)
    {
        total = costo+extras;
        Console.WriteLine($"Usted desea un total de {numtel} televisor(es) extra(as) con un costo de C$ {extras}");
        Console.WriteLine("Usted debe pagar un total de C$ "+total);
    }
}

else

if (plan==2)
{
costo=250;
    Console.WriteLine("Usted ha seleccionado el plan intermedio con un costo de C$ "+costo);
    if (numtel!=0)
    {
        total = costo+extras;
        Console.WriteLine($"Usted desea un total de {numtel} televisor(es) extra(as) con un costo de C$ {extras}");
        Console.WriteLine("Usted debe pagar un total de C$ "+total);
    }
}

else

if (plan==3)
{
costo=500;
    Console.WriteLine("Usted ha seleccionado el plan familiar con un costo de C$ "+costo);
    if (numtel!=0)
    {
        total = costo+extras;
        Console.WriteLine($"Usted desea un total de {numtel} televisor(es) extra(as) con un costo de C$ {extras}");
        Console.WriteLine("Usted debe pagar un total de C$ "+total);
    }
}

else

if (plan==4)
{
costo=900;
    Console.WriteLine("Usted ha seleccionado el plan premium con un costo de C$ "+costo);
    if (numtel!=0)
    {
        total = costo+extras;
        Console.WriteLine($"Usted desea un total de {numtel} televisor(es) extra(as) con un costo de C$ {extras}");
        Console.WriteLine("Usted debe pagar un total de C$ "+total);
    }
}
