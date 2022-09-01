// See https://aka.ms/new-console-template for more information

Double salarioBase;
double horasTrab;
double tarifa;
double tasaImp;
double impuesto;
double pagaNeta;

Console.WriteLine("Introduzca las horas trabajadas: ");
horasTrab = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduzca la tarifa horaria: ");
tarifa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduzca la tasa de impuesto: ");
impuesto = Convert.ToInt32(Console.ReadLine());

tasaImp = impuesto;
salarioBase = tarifa * horasTrab;
impuesto = (salarioBase*tasaImp/100);
pagaNeta = salarioBase-impuesto;

Console.WriteLine("Horas trabajadas: " + horasTrab);
Console.WriteLine("Tarifa: " + tarifa);
Console.WriteLine("Salario base: " + salarioBase);
Console.WriteLine("Impuesto: " + impuesto);
Console.WriteLine("Paga neta: " + pagaNeta);
