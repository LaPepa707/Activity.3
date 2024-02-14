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
                        FERNANDO2();
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
        public static void FERNANDO1()
        {
            #region preguntasEntrenadores

            int score = 0;

            Console.WriteLine("¿Quien es el entrenador actual del Fc Barcelona? ");
            Console.WriteLine("a) Xavi Hernandez b) Pep Guardiola c) Frank Heredia d) Carlo Angelote");
            string respuestaEntrenadores1 = Console.ReadLine();
            bool respuestaCorrecta1 = false;
            switch (respuestaEntrenadores1)
            {
                case "b":
                case "c":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    respuestaCorrecta1 = false;
                    break;

                case "a":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿Quién es el entrenador en conseguir 3 CHAMPIONS seguidas?");
            Console.WriteLine("a) Xavi Hernandez b) Zinedine Zidane c) Mourinho d) Cholo Simeone");
            string respuestaEntrenadores2 = Console.ReadLine();
            bool respuestaCorrecta2 = false;
            switch (respuestaEntrenadores2)
            {
                case "a":
                case "c":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    respuestaCorrecta2 = false;
                break;

                case "b":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta2 = true;
                    score++;
                break;
                    
            }
           

            Console.WriteLine("¿Quien es el entrenador actual del Real de Madrid? ");
            Console.WriteLine("a) Lionel de Messi b) Ronald Koeman c) Carleto Anchelotti d) Jurggen Klopp");
            string respuestaEntrenadores3 = Console.ReadLine();
            bool respuestaCorrecta3 = false;
            switch (respuestaEntrenadores3)
            {
                case "a":
                case "b":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta3 = false;
                break;

                case "c":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta3 = true;
                    score++;
                break;
                    Console.Clear();
            }

            Console.WriteLine("¿Que entrenador a jugado en el Fc Barcelona y ha sido entrenador del Real de Madrid? ");
            Console.WriteLine("a) Pep Guardiola b) Jose Mourinho c) Thierry Henrry d) Mbappe");
            string respuestaEntrenadores4 = Console.ReadLine();
            bool respuestaCorrecta4 = false;
            switch (respuestaEntrenadores4)
            {
                case "a":
                case "c":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    respuestaCorrecta3 = false;
                break;

                case "b":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta3 = true;
                    score++;
                break;
            }

            Console.WriteLine("¿Cual es el entrenador actual del Sevilla Fc? ");
            Console.WriteLine("a) Quique Sanchez Flores b) Jose Luis Mendilibar c) Julen Lopetegui d) Unai Emery");
            string respuestaEntrenadores5 = Console.ReadLine();
            bool respuestaCorrecta5 = false;
            switch (respuestaEntrenadores5)
            {
                case "b":
                case "c":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    respuestaCorrecta3 = false;
                    break;

                case "a":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    respuestaCorrecta3 = true;
                    score++;
                    break;   
            }   
            Console.WriteLine($"DE LA SECCION ENTRENADORES, HAS SACADO UNA PUNTUACION DE {score}/5");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey(); 

            #endregion

        }
        public static void FERNANDO2()
        {
            #region preguntasFutbolistas
            int score = 0;

            Console.WriteLine("¿Quien es el jugador con mas Balones de Oro?");
            Console.WriteLine("a) Cristiano Ronaldo b) Ronaldinho c) Lionel de Messi d) Vini Jr");
            string respuestaEntrenadores1 = Console.ReadLine();
            bool respuestaCorrecta1 = false;
            switch (respuestaEntrenadores1.ToLower())
            {
                case "a":
                case "b":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "c":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿Quien es el jugador mas joven en marcar en la Seleccion Española?");
            Console.WriteLine("a) Lamine Yamal b) Ansumane Fati c) Pedri d) Sergio Ramos");
            string respuestaEntrenadores2 = Console.ReadLine();
            bool respuestaCorrecta2 = false;
            switch (respuestaEntrenadores2.ToLower())
            {
                case "b":
                case "c":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "a":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿Quien fue el jugador mas caro de la historia?");
            Console.WriteLine("a) Maradona b) Paul Pogba c) Neymar Jr d) Samuel Umtiti");
            string respuestaEntrenadores3 = Console.ReadLine();
            bool respuestaCorrecta3 = false;
            switch (respuestaEntrenadores3.ToLower())
            {
                case "a":
                case "b":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "c":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿De estos jugadores, quien tiene mas CHAMPIONS?");
            Console.WriteLine("a) Cristiano Ronaldo b) Sergio Ramos c) Neymar Jr d) Mbappé");
            string respuestaEntrenadores4 = Console.ReadLine();
            bool respuestaCorrecta4 = false;
            switch (respuestaEntrenadores4.ToLower())
            {
                case "c":
                case "b":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "a":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿Que jugador, jugo en la Juventus y en el Manchester United?");
            Console.WriteLine("a) Ousmane Dembelé b) Bellingham c) Paul Pogba d) Amadu Onana");
            string respuestaEntrenadores5 = Console.ReadLine();
            bool respuestaCorrecta5 = false;
            switch (respuestaEntrenadores4.ToLower())
            {
                case "a":
                case "b":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "c":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }
            Console.WriteLine($"DE LA SECCION 'FUTBOLISTAS', HAS SACADO UNA PUNTUACION DE [{score}/5]");
            Console.WriteLine("\n");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
            #endregion
        }
        public static void FERNANDO3()
        {
            #region preguntasEstadios
            int score = 0;

            Console.WriteLine("¿Como se llama el estadio del Real de Madrid?");
            Console.WriteLine("a) Santiago Bernanbeu b) Camp Nou c) Wanda Metropolitano d) Old Trafford");
            string respuestaEntrenadores1 = Console.ReadLine();
            bool respuestaCorrecta1 = false;
            switch (respuestaEntrenadores1.ToLower())
            {
                case "b":
                case "c":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "a":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿Donde se encuentra el estadio del Real Betis Fc?");
            Console.WriteLine("a) Betis b) Barcelona c) Sevilla d) Madrid");
            string respuestaEntrenadores2 = Console.ReadLine();
            bool respuestaCorrecta2 = false;
            switch (respuestaEntrenadores2.ToLower())
            {
                case "b":
                case "c":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "a":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿Qué equipo juega como local en el estadio Signal Iduna Parck?");
            Console.WriteLine("a) Fc Bayern Munchen b) Girona Fc c) Borussia Dortmund d) RB Leipzig");
            string respuestaEntrenadores3 = Console.ReadLine();
            bool respuestaCorrecta3 = false;
            switch (respuestaEntrenadores3.ToLower())
            {
                case "a":
                case "b":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "c":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }

            Console.WriteLine("¿Qué equipo juega como local en el Signal Iduna Parck?");
            Console.WriteLine("a) Fc Bayern Munchen b) Girona Fc c) Borussia Dortmund d) RB Leipzig");
            string respuestaEntrenadores3 = Console.ReadLine();
            bool respuestaCorrecta3 = false;
            switch (respuestaEntrenadores3.ToLower())
            {
                case "a":
                case "b":
                case "d":
                    Console.WriteLine("TE HAS EQUIVOCADO :(");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = false;
                    break;

                case "c":
                    Console.WriteLine("RESPUESTA CORRECTA!!");
                    Console.WriteLine("\n");
                    respuestaCorrecta1 = true;
                    score++;
                    break;
            }





            #endregion
        }
    }
}