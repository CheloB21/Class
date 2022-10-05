// See https://aka.ms/new-console-template for more information

Int16 nums, f=0, suma=0, mult=1;

while (f <= 9)
{
    f++;

    Console.WriteLine("Ingrese un número "+(f)+"\n");
    nums = Convert.ToInt16(Console.ReadLine());

    if (nums >= 0)

    suma += nums;

    else
    {
        if (nums <= 0)
        mult *= nums;
    }
}

Console.WriteLine("");

Console.WriteLine("La suma de los números positivos da como resultado: "+suma);
Console.WriteLine("La multiplicación de los números negativps da como resultado: "+mult);
