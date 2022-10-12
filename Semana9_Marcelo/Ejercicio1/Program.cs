// See https://aka.ms/new-console-template for more information

double num1, num2, suma, multi, div, rest, op;

Console.WriteLine("");
Console.WriteLine("Bienvenido al sistema de operaciones aritméticas");
Console.WriteLine("Seleccione la Opción segun corresponda");
Console.WriteLine("");

do
    {
        Console.WriteLine("");

        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
        Console.Write("Ingrese el número de la operación (1-5): ");
        op = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");

        switch (op)
        {
            case 1:
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            suma = num1+num2;

            Console.WriteLine("La suma de los números ingresados es de: "+suma);

            break;

            case 2:
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            rest = num1-num2;

            Console.WriteLine("La resta de los números ingresados es de: "+rest);

            break;

            case 3:
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            multi = num1*num2;

            Console.WriteLine("La multiplicación de los números ingresados es de: "+multi);

            break;

            case 4:
            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToDouble(Console.ReadLine());

            div = num1/num2;

            Console.WriteLine("La división de los números ingresados es de: "+div);

            break;
        }
    }

    while (op != 5);

    Console.WriteLine("Gracias por utilizar nuestro sistema");
