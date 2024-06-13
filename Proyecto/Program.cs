using TestDemo;

bool finisher = true;
while( finisher == true){
    Console.WriteLine("\n");
    Console.WriteLine("\n");
    Console.WriteLine("\n");
    Console.WriteLine("Bienvenido al cifrado Cesar! Que accion quiere realizar ?\n ");
    Console.WriteLine("1.- Cifrar una palabra:");
    Console.WriteLine("2.- Decifrar una palabra\n");
    Console.WriteLine("Ingrese la accion a realizar 1 o 2:");
    int answer = int.Parse(Console.ReadLine());

    if(answer == 1){ // Si la respuesta es igual a 1 Cifraremos un mensaje

        bool salida2 = true;

        while(salida2){ //loop que permite al usuario volver a usar el cifrado Cesar

            Console.WriteLine("Ingrese la palabra a cifrar: ");
            string mensaje = Console.ReadLine(); //palabra ingresada por el usuario
            if(mensaje == ""){

            Console.WriteLine("No se puede cifrar mensajes vacios!! Ingrese la palabra de nuevo");
            Console.WriteLine("\n");
            continue;

            }else{

                string mensajeOriginal = ""; //Palabra que ingreso el usuario pero limpiada de caracteres 
                for(int i = 0; i < mensaje.Length; ++i){

                    char depurador = mensaje[i];
                    int iterador = depurador;
                    Console.WriteLine(iterador);

                    if(iterador > 64 && iterador < 91 || iterador >= 97 && iterador < 123 ){ //agregue la nueva condicion
                        mensajeOriginal += mensaje[i];
                        Console.WriteLine(mensajeOriginal); 
                        Console.WriteLine("\n");
                    }
                    else if(iterador >= 47 && iterador <= 57 ){ //agregue la nueva condicion 1 - 9
                        mensajeOriginal += mensaje[i];
                        Console.WriteLine(mensajeOriginal); 
                        Console.WriteLine("\n");
                    }
                }

                string mensajeOriginalMayusculas = mensajeOriginal.ToUpper(); //Palabra limpiada de caracteres pero todas son mayusculas
                Console.WriteLine("Tu palabra limpia y lista para ser cifrada es:" + mensajeOriginalMayusculas);
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese la Clave (valores numericos) Debe recordar la clave para volver a decifrar el mensaje");
                int k = int.Parse(Console.ReadLine());
                string cifrado1 = Algorithm.cifrado(mensajeOriginalMayusculas, k); //Usamos nuestra funcion creada para cifrar el mensaje con el algoritmo Cesar
                Console.WriteLine("la palabra cifrada es:" + cifrado1); 
                Console.WriteLine("\n");

                Console.WriteLine("Desea cifrar alguna otra palabra?: 1.- SI      2.- NO");
                Console.WriteLine("Ingrese su opcion 1 o 2:");
                int answer2 = int.Parse(Console.ReadLine());
                if(answer2 == 1){
                    continue;
                }else{
                    salida2 = false;
                }
            }
            
        }   //fin del loop 

        

    } else if(answer == 2){ //Si la respuesta  es igual a 2 Decifraremos un mensaje
        bool salida2 = true;
        while(salida2){ //loop que permite al usuario volver a usar el decifrado Cesar

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Ingrese la palabra a decifrar: ");
            string palabra = Console.ReadLine();
            string palabraMayuscula = palabra.ToUpper(); //Palabra cifrada pero en mayuscula
            Console.WriteLine("Ingrese la clave para decifrar el mensaje: ");
            int k = int.Parse(Console.ReadLine());
             
            string decifrada = Algorithm.descifrado(palabraMayuscula , k); //Usamos nuestra funcion creada para decifrar el mensaje cifrado
            Console.WriteLine("Su palabra decifrada es:" + decifrada );
            Console.WriteLine("\n");
            Console.WriteLine("Desea decifrar alguna otra palabra?: 1.- SI      2.- NO");
            Console.WriteLine("Ingrese 1 o 2:");
            int answer2 = int.Parse(Console.ReadLine());
            if(answer2 == 1){
                continue;
            }else{
                salida2 = false;
            }
        } //Fin el loop

    }else{
        Console.WriteLine("Ingreso valores fuera del rango expecificado vuelva a intentarlo..\n");
        continue;
    }

        Console.WriteLine("Quiere volver a usar el Cifrado o Decifrado Cesar?");
        Console.WriteLine("1.-SI        2.- NO");
        Console.WriteLine("Ingrese el valor de 1 o 2: ");
        int salida = int.Parse(Console.ReadLine());
        if(salida == 1){
            continue;
        }
        else{
            Console.WriteLine("Gracias por usar el Algorithmo de cifrado y decifrado Cesar!!");
            finisher = false;
        }
}   