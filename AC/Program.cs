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
            Console.WriteLine("4 - FUTBOLISTAS");
            Console.WriteLine("5 - ENTRENADORES");
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
            bool Final = false;

            while (!Final)
            {

                while (!respostaCorrecta)
                {

                    Console.WriteLine("1. ¿Cuál de las siguientes especies de primates es conocida por su capacidad de fabricar y utilizar herramientas?");
                    Console.WriteLine("a) Chimpancé b) Gibón c) Tamarino d) Lémur");

                    try
                    {
                        while (!respostaCorrecta)
                        {
                            char respostaChar = Convert.ToChar(Console.ReadLine());

                            switch (respostaChar)
                            {
                                case 'a':
                                    respostaCorrecta = true;
                                    Console.WriteLine("Correcto!!");
                                    break;

                                case 'b':
                                case 'c':
                                case 'd':
                                    throw new Exception("Te has equivocado");
                                    respostaCorrecta = false;
                                    break;

                                default:
                                    Console.WriteLine("Por favor, ingresa una respuesta válida (a, b, c o d).");
                                    break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Oh oh algo no ha ido como se esperaba, vuelve a intentarlo!");
                    }
                }

                respostaCorrecta = false;

                while (!respostaCorrecta) //PREGUNTA 2
                {

                    Console.WriteLine("2. ¿Qué adaptación física ayuda a los camaleones a camuflarse en su entorno?");
                    Console.WriteLine("a) Cola larga   b) Cambio de color en la piel   c) Pico largo  d) Orejas grandes");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'b':
                                respostaCorrecta = true;
                                break;

                            case 'a':
                            case 'c':
                            case 'd':
                                throw new Exception("Te has equivocado");
                                respostaCorrecta = false;
                                break;

                            default:
                                Console.WriteLine("Por favor, ingresa una respuesta válida (a, b, c o d).");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Oh oh algo no ha ido como se esperaba, vuelve a intentarlo!");
                    }

                }

                respostaCorrecta = false;

                while (!respostaCorrecta) //PREGUNTA 3
                {


                    Console.WriteLine("3. ¿En qué bioma podrías encontrar pingüinos emperadores?");
                    Console.WriteLine("a) Desierto\r\n b) Bosque tropical\r\n c) Tundra\r\n d) Selva");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'c':
                                respostaCorrecta = true;
                                break;

                            case 'a':
                            case 'b':
                            case 'd':
                                throw new Exception("Te has equivocado");
                                respostaCorrecta = false;
                                break;

                            default:
                                Console.WriteLine("Por favor, ingresa una respuesta válida (a, b, c o d).");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Oh oh algo no ha ido como se esperaba, vuelve a intentarlo!");
                    }

                }

                respostaCorrecta = false;

                while (!respostaCorrecta)//PREGUNTA 4
                {
                    Console.WriteLine("4 .¿Qué animal es conocido por construir intrincados nidos en forma de colmena?");
                    Console.WriteLine("a) Elefante\r\nb) Abeja\r\nc) Araña\r\nd) Delfín");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'b':
                                respostaCorrecta = true;
                                break;

                            case 'a':
                            case 'c':
                            case 'd':
                                throw new Exception("Te has equivocado");
                                respostaCorrecta = false;
                                break;

                            default:
                                Console.WriteLine("Por favor, ingresa una respuesta válida (a, b, c o d).");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Oh oh algo no ha ido como se esperaba, vuelve a intentarlo!");
                    }
                }

                respostaCorrecta = false;

                while (!respostaCorrecta)//PREGUNTA 5
                {

                    Console.WriteLine("5 .¿Qué animal tiene una lengua tan larga que puede alcanzar su cráneo y se utiliza para alimentarse de insectos");
                    Console.WriteLine("a) Jirafa\r\nb) Oso\r\nc) Camaleón\r\nd) Oso hormiguero");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'd':
                                respostaCorrecta = true;
                                Final = true;
                                break;

                            case 'a':
                            case 'c':
                            case 'b':
                                throw new Exception("Te has equivocado");
                                respostaCorrecta = false;
                                break;

                            default:
                                Console.WriteLine("Por favor, ingresa una respuesta válida (a, b, c o d).");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Oh oh algo no ha ido como se esperaba, vuelve a intentarlo!");
                    }
                    Console.WriteLine("Muy bien, has acabado");
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();

                }
            }
        }
        /// <summary>
        /// FUNCION CON LOS TOPICS DE PRESLAVA
        /// </summary>
        #region PRESLAVA
        public static void PRESLAVA()
        {
            if (Console.ReadKey().Key == ConsoleKey.D7) InstrumentosMusicales();

            if (Console.ReadKey().Key == ConsoleKey.D8) Deportes();

            if (Console.ReadKey().Key == ConsoleKey.D9) Historia();

        }
        /// <summary>
        /// Funcion con las preguntas del tópic historia
        /// </summary>
        #region Historia
        public static void Historia()
        {
            Pregunta1Historia();
            Pregunta2Historia();
            Pregunta3Historia();
            Pregunta4Historia();
            Pregunta5Historia();
        }

        public static void Pregunta4Historia()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("Napoleon fue un rey frances");
            Console.Write("a) Si   b) No -->");
            respuesta = Console.ReadLine();

            if (respuesta == "b" || respuesta == "B")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("Si estuvo al mando de Francia, pero NO fue un rey");
            }
        }

        public static void Pregunta3Historia()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("Japon, durante la segunda guerra mundial, estuvo en el bando de los aliados");
            Console.Write("a) Si   b) No -->");
            respuesta = Console.ReadLine();

            if (respuesta == "b" || respuesta == "B")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("Uff... casi casi, pero NO");
            }
        }

        public static void Pregunta2Historia()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("Existio una tal Guerra de los balcanes?");
            Console.Write("a) Si   b) No -->");
            respuesta = Console.ReadLine();

            if (respuesta == "a" || respuesta == "A")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("Emm... Estudia un poquito de historia, no te vendía mal");
            }
        }

        public static void Pregunta1Historia()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("Cual fue el mayor acontecimiento histórico en el año 1939?");
            Console.Write("a) Segunda guerra mundial    b) Primera guerra mundial   c) Muerte de Kenedi -->");
            respuesta = Console.ReadLine();

            if (respuesta == "a" || respuesta == "A")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("Lo siento... La respuesta correcta es la A");
            }
        }
        #endregion
        /// <summary>
        /// Funcion con las preguntas del tópic deportes
        /// </summary>
        #region Deportes
        public static void Deportes()
        {
            Pregunta1Deportes();
            Pregunta2Deportes();
            Pregunta3Deportes();
            Pregunta4Deportes();
            Pregunta5Deportes();
        }
        #endregion
        /// <summary>
        /// Funcion con las preguntas del tópic Instrumentos Musicales
        /// </summary>
        #region Instrumentos Musicales
        public static void InstrumentosMusicales()
        {
            Pregunta1InstrumentosMusicales();
            Pregunta2InstrumentosMusicales();
            Pregunta3InstrumentosMusicales();
            Pregunta4InstrumentosMusicales();
            Pregunta5InstrumentosMusicales();
        }
        #endregion
        #endregion

    }
}