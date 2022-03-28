using System;

bool Continuar = true;
while (Continuar)
{
    // Definicion De Lineas Principales
    // Mensajes Iniciales
    Console.WriteLine("Bienvenido al programa para registrar los datos de la persona en su respectivo vuelo.");
    Console.WriteLine("");
    Console.WriteLine("Presione Una Tecla Para Continuar ...");
    Console.ReadLine();
    Console.WriteLine("");
    // Fin Mensajes Iniciales

    // Definicion De Variables
    // Variables Principales
    // Variable Opcion
    //int Opcion = Convert.ToInt32(Console.ReadLine());
    // Variable Continuar
    var Tecla_Continuar = "0";
    // Variables Empresa con la que registra el vuelo
    var Compañia = "0";
    // Variables Para conocer si es mayor o menor de edad
    int Edad = 0;
    // Variable Tarifa Basica
    float Tarifa_pasaje = 0;
    float Tarifa_Basica = 0;
    float Tarifa_Edad = 0;
    //float Tarifa_Temperatura = 0;
    float Tarifa_Final = 0;
    float Tarifa_Estudiantes = 0;
    float Tarifa_Recargo = 0;
    // Variable Temperatura
    var Temperatura = "0";
    // Saber Si es Estudiante o particular
    var Estudiante = "0";
    var Particular = "0";
    // Nombre De La Persona
    var nombre = "0";
    // Variable Temperatura
    //var Temperatura = "0";
    // Fin De Definicion De Variables

    // Inicio Ingreso de datos de compañia
    // Compañia
    Console.WriteLine("Porfavor Introduzca El Numero Referente a la De La Compañia: ");
    // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
    Console.WriteLine("1.) - ALAS");
    Console.WriteLine("2.) - VOLAR");
    int Opcion = Convert.ToInt32(Console.ReadLine());

    switch (Opcion)
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                    // ALAS//
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        case 1:
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();
            // Fin Ingreso De compañia

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Ingreso de datos de tarifa basica
            // Tarifa Basica
            Console.WriteLine("Porfavor Introduzca La Tarifa Basica De La Compañia: ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            Tarifa_Basica = float.Parse(Console.ReadLine());
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();
            // Fin Ingreso De Tarifa Basica

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Ingreso de nombre de pasajero
            // Pasajero
            Console.WriteLine("Porfavor Introduzca El Nombre De la persona: ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            nombre = Console.ReadLine();
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();
            // Fin Ingreso De pasajero

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Temperatura
            Console.WriteLine("Porfavor Introduzca La Temperatura De Dia (Alta o Baja): ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            Temperatura = Console.ReadLine();
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);

            // Condicional 
            if (Temperatura == "Alta")
;
            {
                Tarifa_pasaje = Tarifa_Basica + 0.3f;
            }
            
            // Limpia La Consola
            Console.Clear();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////


            // Inicio Ingreso de Edad Del Pasajero
            // Edad
            Console.WriteLine("Porfavor Introduzca La Edad Del Pasajero: ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            Edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();
            if (Edad < 18)
            {
                // Concatena Las palabras y las variables necesarias
                Tarifa_Edad = (Tarifa_Basica / 0.5f);
            };
            // Fin Ingreso De pasajero

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Para Seleccionar si es estudiante o particular
            Console.WriteLine("Porfavor Escoja Alguna de Las 2 Opciones, Dependiendo su Profesion");
            Console.WriteLine("Estudiante");
            Console.WriteLine("Particular");
            Console.WriteLine("");
            //Console.WriteLine(":");
            string resultado = Console.ReadLine();

            switch (resultado)
            {
                // multiples casos para una misma logica
                case "Estudiante":
                case "estudiante":
                case "0":
                    Console.WriteLine("Usted Ha Escogido la opcion estudiante");
                    if (Edad > 18 && Edad < 59 && Temperatura == "baja")
                    {
                        Tarifa_Estudiantes = (Tarifa_Basica / 0.1f);
                    }
                    break;
                default:
                    break;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // Resultados Finales
            Tarifa_Final = Tarifa_Basica + Tarifa_Edad + Tarifa_Estudiantes + Tarifa_pasaje + Tarifa_Recargo;
            Console.WriteLine("");
            Console.WriteLine("Los Datos Obtenidos Corresponden a Los Siguientes.");
            Console.WriteLine("El Nombre Del Pasajero Es: " + nombre);
            Console.WriteLine("La Tarifa Final A Pagar Es: " + Tarifa_Final);
            Console.WriteLine("Muchas Gracias Por Preferirnos!");

            break;
        default:

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                        // VOLAR//
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        case 2:
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();
            // Fin Ingreso De compañia

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Ingreso de datos de tarifa basica
            // Tarifa Basica
            Console.WriteLine("Porfavor Introduzca La Tarifa Basica De La Compañia: ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            Tarifa_Basica = float.Parse(Console.ReadLine());
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Condicional 
            if (Temperatura == "Alta")
            {
                Tarifa_pasaje = Tarifa_Basica + 0.2f;
            }
            // Limpia La Consola
            Console.Clear();
            // Fin Ingreso De Tarifa Basica

            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Ingreso de nombre de pasajero
            // Pasajero
            Console.WriteLine("Porfavor Introduzca El Nombre De la persona: ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            nombre = Console.ReadLine();
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();
            // Fin Ingreso De pasajero

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Temperatura
            Console.WriteLine("Porfavor Introduzca La Temperatura De Dia (Alta o Baja): ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            Temperatura = Console.ReadLine();
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////


            // Inicio Ingreso de Edad Del Pasajero
            // Edad
            Console.WriteLine("Porfavor Introduzca La Edad Del Pasajero: ");
            // lee la entrada del usuario y la guarda en una variable (espacio en memoria)
            Edad = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            Console.WriteLine("Muchas Gracias!");
            Console.WriteLine("");
            // Espera Unos Segundos En La Consola
            //Console.sleep(5);
            // Limpia La Consola
            Console.Clear();
            if (Edad < 18)
            {
                // Concatena Las palabras y las variables necesarias
                Tarifa_Edad = (Tarifa_Basica / 0.5f);
            };
            // Seguro De Vida Calculo //
            if (Edad >= 60)
            {
                Tarifa_Recargo = (Tarifa_Edad + 10000);
            }
            // Fin Ingreso De pasajero


            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // Inicio Para Seleccionar si es estudiante o particular
            Console.WriteLine("Porfavor Escoja Alguna de Las 2 Opciones, Dependiendo su Profesion");
            Console.WriteLine("Estudiante");
            Console.WriteLine("Particular");
            Console.WriteLine("");
            //Console.WriteLine(":");
            resultado = Console.ReadLine();

            switch (resultado)
            {
                // multiples casos para una misma logica
                case "Estudiante":
                case "estudiante":
                case "0":
                    Console.WriteLine("Usted Ha Escogido la opcion estudiante");
                    break;
                default:
                    break;
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            // Resultados Finales
            Tarifa_Final = Tarifa_Basica + Tarifa_Edad + Tarifa_Estudiantes + Tarifa_pasaje + Tarifa_Recargo; 
            Console.WriteLine("");
            Console.WriteLine("Los Datos Obtenidos Corresponden a Los Siguientes.");
            Console.WriteLine("El Nombre Del Pasajero Es: " + nombre);
            Console.WriteLine("La Tarifa Final A Pagar Es: " + Tarifa_Final);
            Console.WriteLine("Muchas Gracias Por Preferirnos!");
            break;

    };
    
}
