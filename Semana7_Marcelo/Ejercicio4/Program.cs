// See https://aka.ms/new-console-template for more information

int f, cuadrado, cubo, conteo=0;
int suma1=0, suma2=0;

Console.WriteLine("Este número calcula los cubos y los cuadrados de los números del 1 al 15");
Console.WriteLine("");

Console.WriteLine("Número   Cuadrado    Cubo");
Console.WriteLine("------   --------    ----");

for(f=1; f<=15; f++)
{
    cuadrado = f*f;
    cubo = f*f*f;
    suma1 = cuadrado+suma1;
    suma2 = cubo+suma2;

    if (cubo>=500)
    conteo = conteo+1;

    Console.WriteLine("{0}       {1}        {2}",f,cuadrado,cubo);
}

Console.WriteLine("");

Console.WriteLine("La suma de los cuadrados es igual a: "+suma1);
Console.WriteLine("La suma de los cubos es igual a: "+suma2);

Console.WriteLine("");

Console.WriteLine("Enlas operaciones realizadas tenemos que hay " +conteo+ " números cubos mayores a 500");

if (suma1>=2000)
{
    Console.WriteLine("La suma de los cuadrados es mayor a 2000");
}
else
{
    Console.WriteLine("La suma de los cuadrados no supera los 2000");
}

Console.WriteLine("");
