// See https://aka.ms/new-console-template for more information

//Tabla de multiplicar

string item1 = "5 x 1 = ",
item2 = "5 x 2 = ",
item3 = "5 x 3 = ",
item4 = "5 x 4 = ",
item5 = "5 x 5 = ",
item6 = "5 x 6 = ",
item7 = "5 x 7 = ",
item8 = "5 x 8 = ",
item9 = "5 x 9 = ",
item10 = "5 x 10 = ";

int res1=5, res2=10, res3=15, res4=20, res5=25, res6=30, res7=35, res8=40, res9=45, res10=50;
int val1,val2, val3, val4, val5, val6, val7, val8, val9, val10;

int puntos=0;

Console.Clear();

Console.WriteLine("Ingrese los resultados de las multiplicaciones como corresponda");

//Console.WriteLine("");

Console.WriteLine($"{item1.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item2.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item3.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item4.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item5.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item6.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item7.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item8.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item9.PadRight(20, '.')}{"?",4} (    )");
Console.WriteLine($"{item10.PadRight(20, '.')}{"?",4} (    )");

Console.SetCursorPosition(27, 1);

val1 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 2);

val2 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 3);

val3 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 4);

val4 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 5);

val5 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 6);

val6 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 7);

val7 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 8);

val8 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 9);

val9 = Convert.ToInt32(Console.ReadLine()!);
Console.SetCursorPosition(27, 10);

val10 = Convert.ToInt32(Console.ReadLine()!);

if (val1 == res1)
    puntos += 1;
if (val2 == res2)
    puntos += 1;
if (val3 == res3)
    puntos += 1;
if (val4 == res4)
    puntos += 1;
if (val5 == res5)
    puntos += 1;
if (val6 == res6)
    puntos += 1;
if (val7 == res7)
    puntos += 1;
if (val8 == res8)
    puntos += 1;
if (val9 == res9)
    puntos += 1;
if (val10 == res10)
    puntos += 1;

Console.WriteLine("El puntaje que obtuviste es de: "+puntos);
