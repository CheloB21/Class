// See https://aka.ms/new-console-template for more information

Int32 contador=0;
String? user, pass, trpass="0";

Console.WriteLine("");

Console.WriteLine("Bienvenido, vamos a crear su usuario: ");
Console.WriteLine("");

Console.WriteLine("Ingrese un nombre de usuario: ");
user = Console.ReadLine();

Console.WriteLine("Ingrese una Contraseña: ");
pass = Console.ReadLine();

Console.WriteLine("");

while (trpass != pass)

{

        Console.WriteLine($"Bienvenido {user} ingrese su contraseña");
        trpass = Console.ReadLine();

            if (trpass == pass)
                {
                    Console.WriteLine("Felicitaciones, ha ingresado a su usuario");
                }

            else
            {
                contador=+1+contador;
                Console.WriteLine("Contraseña erronea, intente nuevamente");
                Console.WriteLine("");
                            
                if (contador >= 3)

                {
                    Console.WriteLine("Demasiados intentos fallidos");
                    break;
                }
            }

}
