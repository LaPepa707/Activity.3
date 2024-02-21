using System;
using System.Linq.Expressions;

namespace AC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                ShowOptions();
                tecla = Console.ReadKey();
                Console.Clear();
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.D2:
                    case ConsoleKey.D3:
                        YARYNA();
                        break;

                    case ConsoleKey.D4:
                        FERNANDO1();
                        break;
                    case ConsoleKey.D5:
                        FERNANDO2();
                        break;
                    case ConsoleKey.D6:
                        FERNANDO3();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.D8:
                    case ConsoleKey.D9:
                        //PRESLAVA();
                        break;

                    case ConsoleKey.D0:
                        //MsgNextScreen("Error. Prem una tecla per tornar al menú...");
                        break;

                }
            } while (tecla.Key != ConsoleKey.D0);
        }

        public static void ShowOptions()
        {
            Console.Clear();
            Console.WriteLine("1 - ANIMALES");
            Console.WriteLine("2 - CAPITALES");
            Console.WriteLine("3 - CANCIONES");
            Console.WriteLine("4 - ENTRENADORES");
            Console.WriteLine("5 - FUTBOLISTAS");
            Console.WriteLine("6 - ESTADIOS");
            Console.WriteLine("7 - INSTRUMENTOS MUSICALES");
            Console.WriteLine("8 -  DEPORTES");
            Console.WriteLine("9 - HISTORIA");
            Console.WriteLine("0 - EXIT");
        }

        public static void YARYNA()
        {
            string resposta;
            bool respostaCorrecta = false;

            while (!respostaCorrecta)
            {
                try
                {
                    Console.WriteLine("1.¿Cuál de las siguientes especies de primates es conocida por su capacidad de fabricar y utilizar herramientas?");
                    Console.WriteLine("a) Chimpancé b) Gibón c) Tamarino d) Lémur");
                    resposta = Console.ReadLine();
                    switch (resposta)
                    {
                        case "b":
                        case "c":
                        case "d":
                            Console.WriteLine("Te has equivocado!!");
                            respostaCorrecta = false;
                            break;

                        case "a":
                            Console.WriteLine("Correcto!!");
                            respostaCorrecta = true;
                            break;

                    }
                }
                catch
                {
                    throw new Exception("Oh oh algo no ha ido como se esperava, vuelve a intentarlo!");

                }
            }




            Console.WriteLine("1.¿Cuál de las siguientes especies de primates es conocida por su capacidad de fabricar y utilizar herramientas?");
            Console.WriteLine("1.¿Cuál de las siguientes especies de primates es conocida por su capacidad de fabricar y utilizar herramientas?");
            Console.WriteLine("1.¿Cuál de las siguientes especies de primates es conocida por su capacidad de fabricar y utilizar herramientas?");
            Console.WriteLine("1.¿Cuál de las siguientes especies de primates es conocida por su capacidad de fabricar y utilizar herramientas?");
            Console.WriteLine("1.¿Cuál de las siguientes especies de primates es conocida por su capacidad de fabricar y utilizar herramientas?");

        }
        //Parte Preguntas Fernando
//        #region comienzaParteFernando
//        public static void FERNANDO1()
//        {
//            #region preguntasEntrenadores

//            int score = 0;

//            Console.WriteLine("¿Quién es el entrenador actual del Fc Barcelona?");
//            Console.WriteLine("a) Xavi Hernández b) Pep Guardiola c) Frank Heredia d) Carlo Ancelotti");

//            string respuestaEntrenadores;
//            bool respuestaCorrecta = false;
//            do
//            {
//                respuestaEntrenadores = Console.ReadLine();

//                switch (respuestaEntrenadores)
//                {
//                    case "a":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta = true;
//                        score++;
//                        break;
//                    case "b":
//                    case "c":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("\n");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta);

//            //PREGUNTA 2
//            Console.WriteLine("¿Quién es el entrenador en conseguir 3 CHAMPIONS seguidas?");
//            Console.WriteLine("a) Xavi Hernandez b) Zinedine Zidane c) Mourinho d) Cholo Simeone");
//            string respuestaEntrenadores2;
//            bool respuestaCorrecta2 = false;
//            do
//            {
//                respuestaEntrenadores2 = Console.ReadLine();
//                switch (respuestaEntrenadores2)
//                {
//                    case "b":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta2 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "c":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("\n");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta2);

//            //PREGUNTA 3
//            Console.WriteLine("¿Quien es el entrenador actual del Real de Madrid? ");
//            Console.WriteLine("a) Lionel de Messi b) Ronald Koeman c) Carleto Anchelotti d) Jurggen Klopp");
//            string respuestaEntrenadores3;
//            bool respuestaCorrecta3 = false;
//            do
//            {
//                respuestaEntrenadores3 = Console.ReadLine();
//                switch (respuestaEntrenadores3)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta3 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("\n");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta3);

//            //PREGUNTA 4
//            Console.WriteLine("¿Que entrenador a jugado en el Fc Barcelona y ha sido entrenador del Real de Madrid? ");
//            Console.WriteLine("a) Pep Guardiola b) Jose Mourinho c) Thierry Henrry d) Mbappe");
//            string respuestaEntrenadores4;
//            bool respuestaCorrecta4 = false;
//            do
//            {
//                respuestaEntrenadores4 = Console.ReadLine();
//                switch (respuestaEntrenadores4)
//                {
//                    case "b":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta4 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "c":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("\n");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta4);

//            //PREGUNTA 5
//            Console.WriteLine("¿Cual es el entrenador actual del Sevilla Fc? ");
//            Console.WriteLine("a) Quique Sanchez Flores b) Jose Luis Mendilibar c) Julen Lopetegui d) Unai Emery");
//            string respuestaEntrenadores5;
//            bool respuestaCorrecta5 = false;
//            do
//            {
//                respuestaEntrenadores5 = Console.ReadLine();
//                switch (respuestaEntrenadores5)
//                {
//                    case "a":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta5 = true;
//                        score++;
//                    //break;
//                    case "b":
//                    case "c":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("\n");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta5);

//            Console.WriteLine($"DE LA SECCION ENTRENADORES, HAS SACADO UNA PUNTUACION DE {score}/5");
//            Console.WriteLine("Presiona cualquier tecla para salir...");
//            Console.ReadKey();
//            #endregion
//        }
//        public static void FERNANDO2()
//        {
//            #region preguntasFutbolistas
//            int score = 0;
//            int intentosFallidos = 0;

//            //PREGUNTA 1:
//            Console.WriteLine("¿Quien es el jugador con mas Balones de Oro?");
//            Console.WriteLine("a) Cristiano Ronaldo b) Ronaldinho c) Lionel de Messi d) Vini Jr");
//            string respuestaFutbolistas;
//            bool respuestaCorrecta = false;
//            do
//            {
//                respuestaFutbolistas = Console.ReadLine();

//                switch (respuestaFutbolistas)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            respuestaCorrecta = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta);

//            //PREGUNTA 2:
//            Console.WriteLine("¿Quien es el jugador mas joven en marcar en la Seleccion Española?");
//            Console.WriteLine("a) Lamine Yamal b) Ansumane Fati c) Pedri d) Sergio Ramos");
//            string respuestaFutbolistas2;
//            bool respuestaCorrecta2 = false;
//            do
//            {
//                respuestaFutbolistas2 = Console.ReadLine();

//                switch (respuestaFutbolistas2)
//                {
//                    case "a":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta2 = true;
//                        score++;
//                        break;
//                    case "b":
//                    case "c":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                            respuestaCorrecta2 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta2);

//            //PREGUNTA 3:
//            Console.WriteLine("¿Quien fue el jugador mas caro de la historia?");
//            Console.WriteLine("a) Maradona b) Paul Pogba c) Neymar Jr d) Samuel Umtiti");
//            string respuestaFutbolistas3;
//            bool respuestaCorrecta3 = false;
//            do
//            {
//                respuestaFutbolistas3 = Console.ReadLine();

//                switch (respuestaFutbolistas3)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta3 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                            respuestaCorrecta3 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta3);

//            //PREGUNTA 4:
//            Console.WriteLine("¿De estos jugadores, quien tiene mas CHAMPIONS?");
//            Console.WriteLine("a) Cristiano Ronaldo b) Sergio Ramos c) Neymar Jr d) Mbappé");
//            string respuestaFutbolistas4;
//            bool respuestaCorrecta4 = false;
//            do
//            {
//                respuestaFutbolistas4 = Console.ReadLine();

//                switch (respuestaFutbolistas4)
//                {
//                    case "a":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta4 = true;
//                        score++;
//                        break;
//                    case "b":
//                    case "c":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                            respuestaCorrecta4 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta4);

//            //PREGUNTA 5:
//            Console.WriteLine("¿Que jugador, jugo en la Juventus y en el Manchester United?");
//            Console.WriteLine("a) Ousmane Dembelé b) Bellingham c) Paul Pogba d) Amadu Onana");
//            string respuestaFutbolistas5;
//            bool respuestaCorrecta5 = false;
//            do
//            {
//                respuestaFutbolistas5 = Console.ReadLine();

//                switch (respuestaFutbolistas5)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta5 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                            respuestaCorrecta5 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta5);

//            Console.WriteLine($"DE LA SECCION 'FUTBOLISTAS', HAS SACADO UNA PUNTUACION DE [{score}/5]");
//            //Console.Clear();
//            Console.WriteLine("\n");
//            Console.WriteLine("Presiona cualquier tecla para salir...");
//            Console.ReadKey();
//            #endregion
//        }
//        public static void FERNANDO3()
//        {
//            #region preguntasEstadios
//            int score = 0;
//            int intentosFallidos = 0;

//            //PREGUNTA 1
//            Console.WriteLine("¿Como se llama el estadio del Real de Madrid?");
//            Console.WriteLine("a) Santiago Bernanbeu b) Camp Nou c) Wanda Metropolitano d) Old Trafford");
//            string respuestaEstadios1;
//            bool respuestaCorrecta1 = false;
//            do
//            {
//                respuestaEstadios1 = Console.ReadLine();

//                switch (respuestaEstadios1)
//                {
//                    case "a":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta1 = true;
//                        score++;
//                        break;
//                    case "b":
//                    case "c":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            respuestaCorrecta1 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta1);

//            //PREGUNTA2
//            Console.WriteLine("¿Donde se encuentra el estadio del Real Betis Fc?");
//            Console.WriteLine("a) Betis b) Barcelona c) Sevilla d) Madrid");
//            string respuestaEstadios2;
//            bool respuestaCorrecta2 = false;
//            do
//            {
//                respuestaEstadios2 = Console.ReadLine();

//                switch (respuestaEstadios2)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta2 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            respuestaCorrecta2 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta2);

//            //PREGUNTA 3
//            Console.WriteLine("¿Qué equipo juega como local en el estadio Signal Iduna Parck?");
//            Console.WriteLine("a) Fc Bayern Munchen b) Girona Fc c) Borussia Dortmund d) RB Leipzig");
//            string respuestaEstadios3;
//            bool respuestaCorrecta3 = false;
//            do
//            {
//                respuestaEstadios3 = Console.ReadLine();

//                switch (respuestaEstadios3)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta3 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            respuestaCorrecta3 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta3);

//            //PREGUNTA 4
//            Console.WriteLine("¿En que sitio se encuentra el estadio del Everton?");
//            Console.WriteLine("a) Londres b) Paris c) Berlin d) Liverpol");
//            string respuestaEstadios4;
//            bool respuestaCorrecta4 = false;
//            do
//            {
//                respuestaEstadios4 = Console.ReadLine();

//                switch (respuestaEstadios4)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta4 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            respuestaCorrecta4 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta4);

//            //PREGUNTA 5
//            Console.WriteLine("¿Que otro nombre recibe San Mamés, el estadio del Athletic Club?");
//            Console.WriteLine("a) El Castillo b) La Muralla c) La Catedral d) La Iglesia");
//            string respuestaEstadios5;
//            bool respuestaCorrecta5 = false;
//            do
//            {
//                respuestaEstadios5 = Console.ReadLine();

//                switch (respuestaEstadios5)
//                {
//                    case "c":
//                        Console.WriteLine("¡RESPUESTA CORRECTA!");
//                        Console.WriteLine("\n");
//                        respuestaCorrecta5 = true;
//                        score++;
//                        break;
//                    case "a":
//                    case "b":
//                    case "d":
//                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
//                        Console.WriteLine("Por favor, intenta de nuevo.");
//                        intentosFallidos++;
//                        if (intentosFallidos >= 3)
//                        {
//                            Console.Clear();
//                            respuestaCorrecta5 = true; // Termina el bucle si excede los dos intentos fallidos
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
//                        break;
//                }
//            } while (!respuestaCorrecta5);

//            Console.WriteLine($"DE LA SECCION 'ESTADIOS', HAS SACADO UNA PUNTUACION DE [{score}/5]");
//            //Console.Clear();
//            Console.WriteLine("\n");
//            Console.WriteLine("Presiona cualquier tecla para salir...");
//            Console.ReadKey();
//            #endregion
//        }
//        #endregion
//    }
//}