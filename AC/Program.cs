using System.Linq.Expressions;

namespace AC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///TOPICS YARYNA
            ///1. ANIMALES
            ///2. CAPITALES
            ///3. CANCIONES
            ///TOPICS FER
            ///1. FURBOLISTAS
            ///2. ESTADIOS
            ///3. ENTRENADORES
            ///TOPCIS PRES
            ///1. INSTRUMENTOS MUSICALES
            ///2. DEPORTES
            ///3. HISTORIA
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
                    case ConsoleKey.D5:
                    case ConsoleKey.D6:
                        FERNANDO();
                        break;

                    case ConsoleKey.D7:
                    case ConsoleKey.D8:
                    case ConsoleKey.D9:
                        PRESLAVA();
                        break;

                    case ConsoleKey.D0:
                        MsgNextScreen("Error. Prem una tecla per tornar al menú...");
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
            Console.WriteLine("5 - FUTBOLISTAS");
            Console.WriteLine("6 - ENTRENADORES");
            Console.WriteLine("7 - ESTADIOS");
            Console.WriteLine("8 - INSTRUMENTOS MUSICALES");
            Console.WriteLine("9 -  DEPORTES");
            Console.WriteLine("10 - HISTORIA");
            Console.WriteLine("0 - EXIT");
        }

        public static void YARYNA()
        {
            string resposta;
            bool respostaCorrecta;

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

    }
}