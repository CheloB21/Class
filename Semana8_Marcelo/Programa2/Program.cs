// See https://aka.ms/new-console-template for more information

Int16 num, f=0, suma=0;

while (f >= 0)
{
    
    Console.Write("Ingresa un número: ");
    num = Convert.ToInt16(Console.ReadLine());

    {

        if (num>=0)
        
            suma+=num;
        else
        
            if (num<=0)
            {
                Console.WriteLine("La suma de los números ingresados es: "+suma);
                break;
            }

    }    

}




