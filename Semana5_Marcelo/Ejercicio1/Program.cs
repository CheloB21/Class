// See https://aka.ms/new-console-template for more information

string item1 = "A. Un sexto",
item2 = "B. Dos novenos",
item3 = "C. Tres Medios",
item4 = "D. Seis Octavos",
item5 = "E. Tres Quintos",
item6 = "F. Dos Tercios",
item7 = "G. Un Décimo";

char val1, val2, val3, val4, val5, val6, val7;

string resp1 = "1/10", resp2 = "2/3", resp3 = "1/6", resp4 = "6/8", resp5 = "2/9", resp6 = "3/5", resp7 = "3/2";

int sumapts = 0;

Console.Clear();

Console.WriteLine("Relacione cada operación planteada en la izquierda con el cociente que le corresponde a la derecha");

Console.WriteLine("");

Console.WriteLine($"{item1.PadRight(20, '.')}{resp1,4} (   )");
Console.WriteLine($"{item2.PadRight(20, '.')}{resp2,4} (   )");
Console.WriteLine($"{item3.PadRight(20, '.')}{resp3,4} (   )");
Console.WriteLine($"{item4.PadRight(20, '.')}{resp4,4} (   )");
Console.WriteLine($"{item5.PadRight(20, '.')}{resp5,4} (   )");
Console.WriteLine($"{item6.PadRight(20, '.')}{resp6,4} (   )");
Console.WriteLine($"{item7.PadRight(20, '.')}{resp7,4} (   )");

Console.SetCursorPosition(27, 1);

val1 = Convert.ToChar(Console.ReadLine()!);
Console.SetCursorPosition(27, 2);

val2 = Convert.ToChar(Console.ReadLine()!);
Console.SetCursorPosition(27, 3);

val3 = Convert.ToChar(Console.ReadLine()!);
Console.SetCursorPosition(27, 4);

val4 = Convert.ToChar(Console.ReadLine()!);
Console.SetCursorPosition(27, 5);

val5 = Convert.ToChar(Console.ReadLine()!);
Console.SetCursorPosition(27, 6);

val6 = Convert.ToChar(Console.ReadLine()!);
Console.SetCursorPosition(27, 7);

val7 = Convert.ToChar(Console.ReadLine()!);

if (val1 == 'c')
    sumapts += 1;
if (val2 == 'E');
    sumapts += 1;
if (val3 == 'G');
    sumapts += 1;
if (val4 == 'D');
    sumapts += 1;
if (val5 == 'F');
    sumapts += 1;
if (val6 == 'B');
    sumapts += 1;
if (val7 == 'A');
    sumapts += 1;

Console.WriteLine("");

Console.WriteLine($"Total de puntos {sumapts}");
