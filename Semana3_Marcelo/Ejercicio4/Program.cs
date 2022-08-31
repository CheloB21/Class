// See https://aka.ms/new-console-template for more information

const float impuesto=25.00f;
float horas, cantidad, bruto, neto;

Console.WriteLine("Bienvenido al sistema de cálculo por horario trabajado");
Console.WriteLine("");
Console.Write("Ingresa la cantidad de horas que trabajaste: ");
horas=Convert.ToSingle(Console.ReadLine());

Console.Write("Ingresa el pago correspondiente por horas en C$: ");
cantidad=Convert.ToSingle(Console.ReadLine());

bruto=horas*cantidad;
neto=bruto-impuesto;

Console.Clear();

Console.WriteLine("Su ingreso bruto mensual es de C$ "+bruto);
Console.WriteLine("Una vez restado el impuesto el neto a recibir es de C$ "+neto);
