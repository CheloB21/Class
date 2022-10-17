int opcion;
int  audio=0, visual=0, kinestesico=0;
string? opc1="", opc2="";
/**inicia programa*/

menu:

Console.Clear();
Console.WriteLine("seleccione una opción");
Console.WriteLine("1. Complete");
Console.WriteLine("2. Selección única");
Console.WriteLine("3. Selección múltiple");
Console.WriteLine("4. SALIR");
opcion=Convert.ToInt32(Console.ReadLine());

while(opcion != 4)
{

switch (opcion)
{
case 1:

//Complete N° 1

        Console.Clear();

        Console.WriteLine("Complete inciso 1");

        Console.WriteLine("Completa de acuerdo a tu preferencia: dibujo, digo, recojo");

        Console.WriteLine("Te encuentras a punto de dar instrucciones a una persona, esa persona no es de tu ciudad ");
        Console.WriteLine("y necesita llegar a un lugar, para indicarle yo le ______ para indicarle donde es el lugar.");

        Console.SetCursorPosition(51, 3);
        opc1 = Console.ReadLine();

          switch(opc1)
          {
            case "dibujo":
                          visual = visual+2;
            break;

            case "digo":
                          audio = audio+2;
            break;

            case "recojo":
                          kinestesico = kinestesico+2;
            break;

            break;
          }     

//Complete N° 2

        Console.Clear();

        Console.WriteLine("Complete inciso 2");

        Console.WriteLine("Completa de acuerdo a tu preferencia: veo la palabra en mi mente, repito la palabra en mi mente, escribo ambas y escojo una.");

        Console.WriteLine("No estoy seguro de como se escribe una palabra así que yo ________________________________ ");

        Console.SetCursorPosition(58, 2);
        opc1 = Console.ReadLine();

          switch(opc1)
          {
            case "veo la palabra en mi mente":
                          visual = visual+2;
            break;

            case "repito la palabra en mi mente":
                          audio = audio+2;
            break;

            case "escribo ambas y escojo una":
                          kinestesico = kinestesico+2;
            break;

            break;
          }

//Complete N° 3

        Console.Clear();

        Console.WriteLine("Complete inciso 3");

        Console.WriteLine("Completa de acuerdo a tu preferencia: le llamo inmediatamente por telefono, se lo muestro en un mapa mundi, le comparto que se hace en cada lugar.");

        Console.WriteLine("Recibes una copia de un plan de viaje para un recorrido alrededor del mundo y un amigo tuyo está interesado en el, yo ________________________________ ");

        Console.SetCursorPosition(118, 2);
        opc1 = Console.ReadLine();

          switch(opc1)
          {
            case "se lo muestro en un mapa mundi":
                          visual = visual+2;
            break;

            case "le llamo inmediatamente por telefono":
                          audio = audio+2;
            break;

            case "le comparto que se hace en cada lugar":
                          kinestesico = kinestesico+2;
            break;

            break;
          }

//Complete N° 4

        Console.Clear();

        Console.WriteLine("Complete inciso 4");

        Console.WriteLine("Completa de acuerdo a tu preferencia: cocino algo sin instrucciones, busco imagenes de recetas, busco un video tutorial que me guie.");

        Console.WriteLine("Cocinaré algo especial para mi familia así que: ________________________________ ");

        Console.SetCursorPosition(48, 2);
        opc1 = Console.ReadLine();

          switch(opc1)
          {
            case "busco imagenes de recetas":
                          visual = visual+2;
            break;

            case "busco un video tutorial que me guie":
                          audio = audio+2;
            break;

            case "cocino algo sin instrucciones":
                          kinestesico = kinestesico+2;
            break;

            break;
          }

//Complete N° 5

        Console.Clear();

        Console.WriteLine("Complete inciso 5");

        Console.WriteLine("Completa de acuerdo a tu preferencia: le doy un recorrido en auto, les muestro fotografias y diapositivas, les doy una charla sobre la reserva.");

        Console.WriteLine("Me asignan un grupo de turistas para enseñarles una reserva de pinos así que yo ________________________________ ");

        Console.SetCursorPosition(80, 2);
        opc1 = Console.ReadLine();

          switch(opc1)
          {
            case "les muestro fotografias y diapositivas":
                          visual = visual+2;
            break;

            case "les doy una charla sobre la reserva":
                          audio = audio+2;
            break;

            case "le doy un recorrido en auto":
                          kinestesico = kinestesico+2;
            break;

            break;
          }

        Console.WriteLine("");

        Console.WriteLine("Presiona Enter para volver al menú");
        
        Console.ReadLine();

        goto menu;    
    
case 2:
      Console.Clear();
      Console.WriteLine("Selección única pregunta # 1 ");
      Console.WriteLine("Te encuentras a punto de comprar una laptop. ¿Qué otro factor además del precio, influiría en tu decisión?");
      Console.WriteLine("a) Me gusta el color.");
      Console.WriteLine("b) Tomo en cuenta las indicaciones del vendedor.");
      Console.WriteLine("c) Tomo la decisión basada en mis sentimientos.");
      Console.WriteLine("Opcion: ");
      Console.SetCursorPosition(9,5);
      opc1 = Console.ReadLine();

        switch(opc1)
        {
            case "a":
                    visual = visual + 2 ;
            break;

            case "b":
                    audio = audio + 2 ;
            break;

            case "c":
                    kinestesico = kinestesico + 2 ;
            break;
        }

//pregunta selección única 2
        Console.Clear();
        Console.WriteLine("Selección única pregunta # 2 ");
        Console.WriteLine("Recuerda un momento especifico de tu vida por ejemplo andar en bicicleta ¿Cómo lograste aprender mejor?");
        Console.WriteLine("a) Viendo a alguien mas hacerlo.");
        Console.WriteLine("b) Escuchando orientaciones");
        Console.WriteLine("c) Aprendi haciendolo con compañia-");
        Console.WriteLine("Opcion: ");
        Console.SetCursorPosition(9,5);
        opc1 = Console.ReadLine();

              switch(opc1)
              {
                  case "a":
                          visual = visual + 2 ;
                  break;

                  case "b":
                          audio = audio + 2 ;
                  break;

                  case "c":
                          kinestesico = kinestesico + 2 ;
                  break;
              }
//pregunta selección única 3
        Console.Clear();
        Console.WriteLine("Selección única pregunta # 3 ");
        Console.WriteLine("Tienes un problema de salud, prefieres que el doctor: ");
        Console.WriteLine("a) Te diga directamente que esta mal.");
        Console.WriteLine("b) Te muestre con un diagrama o grafico lo que esta mal");
        Console.WriteLine("c) Use un modelo para mostrarte lo que esta mal");
        Console.WriteLine("Opcion: ");
        Console.SetCursorPosition(9,5);
        opc1 = Console.ReadLine();

            switch(opc1)
            {
                case "a":
                        audio = audio + 2 ;
                break;

                case "b":
                        visual = visual + 2 ;
                break;

                case "c":
                        kinestesico = kinestesico + 2 ;
                break;
            }
//pregunta selección única 4
        Console.Clear();
        Console.WriteLine("Selección única pregunta # 4 ");
        Console.WriteLine("Instalas un nuevo programa en tu computadora ¿Qué harías?  ");
        Console.WriteLine("a) Experimentar con el programa");
        Console.WriteLine("b) Llamar a un amigo que te indique como usarlo.");
        Console.WriteLine("c) Ver un tutorial en internet.");
        Console.WriteLine("Opcion: ");
        Console.SetCursorPosition(9,5);
        opc1 = Console.ReadLine();

          switch(opc1)
          {
              case "a":
                      kinestesico = kinestesico + 2 ;
              break;

              case "b":
                      audio = audio + 2 ;
              break;

              case "c":
                      visual = visual + 2 ;
              break;
          }
//pregunta selección única 5
        Console.Clear();
        Console.WriteLine("Selección única pregunta # 5 ");
        Console.WriteLine("Vas a visitar a unos amigos a otra ciudad que no conoces. ¿Qué te gustaría que hicieran tus amigos?");
        Console.WriteLine("a) Te envien el enlace de Google Maps");
        Console.WriteLine("b) Te den las instruccion por telefono para llegar");
        Console.WriteLine("c) Te esperen en la gasolinera o entrada de la ciudad.");
        Console.WriteLine("Opcion: ");
        Console.SetCursorPosition(9,5);
        opc1 = Console.ReadLine();

            switch(opc1)
            {
                case "a":
                        visual = visual + 2 ;
                break;

                case "b":
                        audio = audio + 2 ;
                break;

                case "c":
                        kinestesico = kinestesico + 2 ;
                break;
            }
            
        Console.WriteLine("");

        Console.WriteLine("Presiona Enter para volver al menú");
        
        Console.ReadLine();

        goto menu;

case 3:
    

        Console.Clear();
        Console.WriteLine("Seleccion multiple pregunta # 1 ");
        Console.WriteLine("Ingresa 2 opciones en el orden de tu preferencia ");
        Console.WriteLine("Prefieres que un profesor use:    ");
        Console.WriteLine("a) Diagramas de flujo, cuadros, diapositivas y graficos. ");
        Console.WriteLine("b) Excursiones, laboratorios y sesiones prácticas.");
        Console.WriteLine("c) Discusiones, debates o profesores invitados");
        Console.SetCursorPosition(33,2);
        opc1 = Console.ReadLine();

        Console.SetCursorPosition(36,2);
        opc2 = Console.ReadLine();
        Console.SetCursorPosition(0,7);
              if(opc1 == "a")
              {
                visual = visual + 2 ;
              }else
                  if(opc1 == "b")
                    {
                      kinestesico = kinestesico + 2 ;
                    }else
                      if(opc1 == "c")
                      { 
                        audio = audio + 2 ;
                      }
              if(opc2 == "a")
              {
                visual = visual + 1 ;
              }else
                  if(opc2 == "b")
                    {
                      kinestesico = kinestesico + 1 ;
                    }else
                      if(opc2 == "c")
                      { 
                          audio = audio + 1 ;
                      }

//pregunta numero 2
        opc1 = "";
        opc2 = "";
        Console.Clear();
        Console.WriteLine("Seleccion multiple preguna # 2 ");
        Console.WriteLine("Ingresa 2 opciones en el orden de tu preferencia ");
        Console.WriteLine("Si pudieras adquirir dos de los siguientes artículos,¿Cuales serian?:    ");
        Console.WriteLine("a) Un Jacuzzi. ");
        Console.WriteLine("b) Un Estéreo.");
        Console.WriteLine("c) Un Televisor");

        Console.SetCursorPosition(70,2);
        opc1 = Console.ReadLine();

        Console.SetCursorPosition(73,2);
        opc2 = Console.ReadLine();
        Console.SetCursorPosition(0,7);

                if(opc1 == "a")
                {
                  kinestesico = kinestesico + 2 ;
                }else
                    if(opc1 == "b")
                      {
                        audio = audio + 2 ;
                      }else
                        if(opc1 == "c")
                        { 
                        visual = visual + 2 ;
                        }
                if(opc2 == "a")
                {
                  kinestesico = kinestesico + 1 ;
                }else
                    if(opc2 == "b")
                      {
                        audio = audio + 1 ;
                      }else
                        if(opc2 == "c")
                        { 
                          visual = visual + 1 ;
                        }
//pregunta numero 3
        opc1 = "";
        opc2 = "";
        Console.Clear();
        Console.WriteLine("Seleccion multiple preguna # 3 ");
        Console.WriteLine("Ingresa 2 opciones en el orden de tu preferencia ");
        Console.WriteLine("¿Qué prefieres hacer un sabado por la tarde?:    ");
        Console.WriteLine("a) Quedarte en casa. ");
        Console.WriteLine("b) Ir a un concierto.");
        Console.WriteLine("c) Ir al cine");

        Console.SetCursorPosition(47,2);
        opc1 = Console.ReadLine();

        Console.SetCursorPosition(49,2);
        opc2 = Console.ReadLine();

              if(opc1 == "a")
              {
                kinestesico = kinestesico + 2 ;
              }else
                  if(opc1 == "b")
                    {
                      audio = audio + 2 ;
                    }else
                      if(opc1 == "c")
                      { 
                      visual = visual + 2 ;
                      }
              if(opc2 == "a")
              {
                kinestesico = kinestesico + 1 ;
              }else
                  if(opc2 == "b")
                    {
                      audio = audio + 1 ;
                    }else
                      if(opc2 == "c")
                      { 
                        visual = visual + 1 ;
                      }
//pregunta numero 4
        opc1 = "";
        opc2 = "";
        Console.Clear();
        Console.WriteLine("Seleccion multiple preguna # 4 ");
        Console.WriteLine("Ingresa 2 opciones en el orden de tu preferencia ");
        Console.WriteLine("¿Qué tipo de examenes prefieres realizar?:    ");
        Console.WriteLine("a) Examen en Línea. ");
        Console.WriteLine("b) Examen oral.");
        Console.WriteLine("c) Examen escrito");

        Console.SetCursorPosition(44,2);
        opc1 = Console.ReadLine();

        Console.SetCursorPosition(46,2);
        opc2 = Console.ReadLine();

              if(opc1 == "a")
              {
                visual = visual + 2 ;
              }else
                  if(opc1 == "b")
                    {
                      audio = audio + 2 ;
                    }else
                      if(opc1 == "c")
                      { 
                      kinestesico = kinestesico + 2 ;
                      }
              if(opc2 == "a")
              {
                visual = visual + 1 ;
              }else
                  if(opc2 == "b")
                    {
                      audio = audio + 1 ;
                    }else
                      if(opc2 == "c")
                      { 
                        kinestesico = kinestesico + 1 ;
                      }
//pregunta numero 5
          opc1 = "";
          opc2 = "";
          Console.Clear();
          Console.WriteLine("Seleccion multiple preguna # 5 ");
          Console.WriteLine("Ingresa 2 opciones en el orden de tu preferencia ");
          Console.WriteLine("¿En que prefieres ocupar tu tiempo en un lugar de descanso?:    ");
          Console.WriteLine("a) Leer un libro. ");
          Console.WriteLine("b) Caminar por los alrededores.");
          Console.WriteLine("c) Conversar con las personas del lugar");

          Console.SetCursorPosition(62,2);
          opc1 = Console.ReadLine();

          Console.SetCursorPosition(64,2);
          opc2 = Console.ReadLine();

              if(opc1 == "a")
              {
                visual = visual + 2 ;
              }else
                  if(opc1 == "b")
                    {
                      kinestesico = kinestesico + 2 ;
                    }else
                      if(opc1 == "c")
                      { 
                      audio = audio + 2 ;
                      }
              if(opc2 == "a")
              {
                visual = visual + 1 ;
              }else
                  if(opc2 == "b")
                    {
                      kinestesico = kinestesico + 1 ;
                    }else
                      if(opc2 == "c")
                      { 
                        audio = audio + 1 ;
                      }
        
        Console.WriteLine("");

        Console.WriteLine("Presiona Enter para volver al menú");
        
        Console.ReadLine();
        
        goto menu;


}

}

//Entrega el estilo de aprendizaje

if (visual>audio)
{
    if (visual>kinestesico)
    {
        Console.WriteLine("Tu estilo de aprendizaje es Visual");

        Console.WriteLine("");

        Console.WriteLine("Las personas con estilo de aprendizaje Visual se caracterizan por: ");

        Console.WriteLine("");

        Console.WriteLine("Son personas observadoras.");
        Console.WriteLine("Tienen mucha imaginación.");
        Console.WriteLine("Las imágenes y los esquemas son más efectivos para estudiar.");
        Console.WriteLine("Dificultades para recordar explicaciones verbales.");
        Console.WriteLine("Piensan con imágenes más que en palabras.");
        Console.WriteLine("Recuerdan videos y presentaciones con gráficos.");
    }
    else
    {
        Console.WriteLine("Tu estilo de aprendizaje es Kinestésico");

        Console.WriteLine("");

        Console.WriteLine("Las personas con estilo de aprendizaje Kinestésico se caracterizan por: ");

        Console.WriteLine("");

        Console.WriteLine("Ser personas capaces de explorar el entorno y los objetos por medio el tacto y el movimiento. Tienen muy desarrollado el sentido del ritmo y la coordinación. Muestran una mayor facilidad para aprender a través de la experiencia directa y la participación.");

    }
} else

if (audio>kinestesico)
{
    Console.WriteLine("Tu estilo de aprendizaje es auditivo");

        Console.WriteLine("");

        Console.WriteLine("Las personas con estilo de aprendizaje auditivo se caracterizan por: ");

        Console.WriteLine("");

        Console.WriteLine("Aprender mejor cuando reciben las explicaciones oralmente y cuando pueden hablar y explicar esa información a otra persona. La persona con estilo auditivo necesita escuchar su grabación mental paso a paso; les cuesta trabajo relacionar conceptos o elaborar conceptos abstractos.");
}
else
{
    Console.WriteLine("Tu estilo de aprendizaje es Kinestesico");

    Console.WriteLine("");

        Console.WriteLine("Las personas con estilo de aprendizaje Kinestésico se caracterizan por: ");

        Console.WriteLine("");

        Console.WriteLine("Ser personas capaces de explorar el entorno y los objetos por medio el tacto y el movimiento. Tienen muy desarrollado el sentido del ritmo y la coordinación. Muestran una mayor facilidad para aprender a través de la experiencia directa y la participación.");
}

