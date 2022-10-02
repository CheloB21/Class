// See https://aka.ms/new-console-template for more information

Double compra, resta, pagar;

Console.WriteLine("Bienvenido al Supermercado");
Console.WriteLine("En este sistema usted podra conocer su descuento");

Console.Write("Por favor ingrese el monto de su compra: C$ ");
compra = Convert.ToDouble(Console.ReadLine());

if (compra <= 500)
Console.WriteLine("Ustes no aplica para descuento");

else

if (compra >= 500 && compra <= 1000)
    {
    resta = compra*0.05;
    pagar = compra - resta;

    Console.WriteLine("Usted aplica un descuento");
    Console.WriteLine("Su descuento es del 5%");
    Console.WriteLine("Usted tendrá que pagar C$ "+pagar);
    }

else

if (compra >= 1000 && compra <= 7000)
    {
    resta = compra*0.11;
    pagar = compra - resta;

    Console.WriteLine("Usted aplica un descuento");
    Console.WriteLine("Su descuento es del 11%");
    Console.WriteLine("Usted tendrá que pagar C$ "+pagar);
    }

else

if (compra >= 7000 && compra <= 15000)
    {
    resta = compra*0.18;
    pagar = compra - resta;

    Console.WriteLine("Usted aplica un descuento");
    Console.WriteLine("Su descuento es del 18%");
    Console.WriteLine("Usted tendrá que pagar C$ "+pagar);
    }

else

if (compra >= 15000)
    {
    resta = compra*0.25;
    pagar = compra - resta;

    Console.WriteLine("Usted aplica un descuento");
    Console.WriteLine("Su descuento es del 25%");
    Console.WriteLine("Usted tendrá que pagar C$ "+pagar);
    }
