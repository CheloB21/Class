// See https://aka.ms/new-console-template for more information

double sb;
double v1;
double v2;
double v3;
double comision;
double gm;

Console.WriteLine("Ingrese el sueldo base"); 
sb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ingrese el valor de la venta 1");
v1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ingrese el valor de la venta 2");
v2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine(" ingrese el valor de la venta 3");
v3=Convert.ToDouble(Console.ReadLine());

comision = (v1+v2+v3)*0.10;
gm=(sb+comision);

Console.WriteLine(" su ganancia mensual es : " +gm);
