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
                        YARYNA(tecla);
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
                        PRESLAVA(tecla);
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
            Console.WriteLine("4 - FUTBOLISTAS");
            Console.WriteLine("5 - ENTRENADORES");
            Console.WriteLine("6 - ESTADIOS");
            Console.WriteLine("7 - INSTRUMENTOS MUSICALES");
            Console.WriteLine("8 - DEPORTES");
            Console.WriteLine("9 - HISTORIA");
            Console.WriteLine("0 - EXIT");
        }
        public static void MsgNextScreen(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public static void YARYNA(ConsoleKeyInfo tecla)
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
                Console.Clear();
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
                Console.Clear();
                respostaCorrecta = false;
                //NO BORRAR NADA
                while (!respostaCorrecta) //PREGUNTA 3
                {


                    Console.WriteLine("3. ¿En qué bioma podrías encontrar pingüinos emperadores?");
                    Console.WriteLine("a) Desierto b) Bosque tropical c) Tundra d) Selva");

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
                Console.Clear();
                respostaCorrecta = false;
                //NO BORRAR NADA
                while (!respostaCorrecta)//PREGUNTA 4
                {
                    Console.WriteLine("4 .¿Qué animal es conocido por construir intrincados nidos en forma de colmena?");
                    Console.WriteLine("a) Elefante b) Abejac) Araña d) Delfín");

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
                Console.Clear();
                respostaCorrecta = false;
                //NO BORRAR NADA
                while (!respostaCorrecta)//PREGUNTA 5
                {

                    Console.WriteLine("5 .¿Qué animal tiene una lengua tan larga que puede alcanzar su cráneo y se utiliza para alimentarse de insectos");
                    Console.WriteLine("a) Jirafa b) Oso c) Camaleón d) Oso hormiguero");

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
        //NO BORRAR NADA
        public static void CapitalesP()
        {
            string resposta;
            bool respostaCorrecta = false;
            bool Final = false;

            while (!Final)
            {

                while (!respostaCorrecta)
                {

                    Console.WriteLine("1. ¿Cuál es la capital mas conocida del mundo");
                    Console.WriteLine("a) Tokio b) Madrid c) New York d) Londres");

                    try
                    {
                        while (!respostaCorrecta)
                        {
                            char respostaChar = Convert.ToChar(Console.ReadLine());

                            switch (respostaChar)
                            {
                                case 'd':
                                    respostaCorrecta = true;
                                    Console.WriteLine("Correcto!!");
                                    break;

                                case 'b':
                                case 'c':
                                case 'a':
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
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta) //PREGUNTA 2
                {

                    Console.WriteLine("2. Capital mas visitada  del mundo en 2022");
                    Console.WriteLine("a) Madrid   b) París  c) Lima  d)Londres");

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
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta) //PREGUNTA 3
                {


                    Console.WriteLine("3. Capital de etiopia");
                    Console.WriteLine("a) Asmara  b)Adís.Abeba  c)Yamusukro,Abiyán  d) Bissau");

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
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta)//PREGUNTA 4
                {
                    Console.WriteLine("4 .Capital de Madagascar");
                    Console.WriteLine("a) Yamusukro b) Yamenia c) Antanaribo d) Nicosia");

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
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta)//PREGUNTA 5
                {

                    Console.WriteLine("5 .Capital de Libia");
                    Console.WriteLine("a) Trípoli b) Bengasi c) Toburk d) Manila");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'a':
                                respostaCorrecta = true;
                                Final = true;
                                break;

                            case 'd':
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
        //NO BORRAR NADA
        public static void CancionesP()
        {

            string resposta;
            bool respostaCorrecta = false;
            bool Final = false;

            while (!Final)
            {

                while (!respostaCorrecta)
                {

                    Console.WriteLine("1. ¿Cuál es la canción con mas visualizaciones del mundo");
                    Console.WriteLine("a) Bohemian Rhapsody b) Despacito c) Shape of you d) Imagine");

                    try
                    {
                        while (!respostaCorrecta)
                        {
                            char respostaChar = Convert.ToChar(Console.ReadLine());

                            switch (respostaChar)
                            {
                                case 'b':
                                    respostaCorrecta = true;
                                    Console.WriteLine("Correcto!!");
                                    break;

                                case 'd':
                                case 'c':
                                case 'a':
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
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta) //PREGUNTA 2
                {

                    Console.WriteLine("2. Quien canta la canción de Smells Like Teen Spirit");
                    Console.WriteLine("a) The beatles   b) Queens  c) Nirvana  d)Bob Dylan");

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
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta) //PREGUNTA 3
                {


                    Console.WriteLine("3. ¿Qué país inició la música pop?");
                    Console.WriteLine("a) UA y en UK b)UK c)UA d) Australia");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'a':
                                respostaCorrecta = true;
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
                    catch (Exception ex)
                    {
                        Console.WriteLine("Oh oh algo no ha ido como se esperaba, vuelve a intentarlo!");
                    }

                }
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta)//PREGUNTA 4
                {
                    Console.WriteLine("4 .De quien es esta canción: In the town where I was born Lived a man who sailed to sea");
                    Console.WriteLine("a) The beatles   b) Queens  c) Nirvana  d)Bob Dylan");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'a':
                                respostaCorrecta = true;
                                break;

                            case 'c':
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
                Console.Clear();
                respostaCorrecta = false;

                while (!respostaCorrecta)//PREGUNTA 5
                {

                    Console.WriteLine("5 .Quien es precursor del reggaeton");
                    Console.WriteLine("a)  Bad Bunny b)Daddy Yankee  c) Anuel d) Michael Ellis");

                    try
                    {
                        char respostaChar = Convert.ToChar(Console.ReadLine());

                        switch (respostaChar)
                        {
                            case 'b':
                                respostaCorrecta = true;
                                Final = true;
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
        public static void PRESLAVA(ConsoleKeyInfo key)
        {

            if (key.Key == ConsoleKey.D7) InstrumentosMusicales();

            if (key.Key == ConsoleKey.D8) Deportes();

            if (key.Key == ConsoleKey.D9) Historia();

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

        public static void Pregunta5Historia()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿Quienes fueron los miembros que conformaban los aliados?");
            Console.Write("a) Inglaterra, EEUU, y la URSS   b) Inglaterra, Japón, y la URSS  c) Inglaterra, EEUU, la URSS y FRancia  d) Alemania, Italia y Japón -->    ");
            respuesta = Console.ReadLine();

            if (respuesta == "c" || respuesta == "C")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("No, no, INCORRECTO");
            }

            MsgNextScreen("PRESIONA UNA TECLA PARA VOLVER AL MENU");
        }

        public static void Pregunta4Historia()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("Napoleón Bonaparte fue...");
            Console.Write("a) un rey   b) un emperador  c) un Papa  d) un comerciante -->   ");
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
                Console.WriteLine("Me da a mi que no. INCORRECTO");
            }
        }

        public static void Pregunta3Historia()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("Japon, durante la segunda guerra mundial, estuvo del bando...");
            Console.Write("a) de los aliados   b) de las potencias del eje   c) de las potencias aliadas    d) del eje-->   ");
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

            Console.WriteLine("¿En que año comenzó la primera guerra de los balcanes?");
            Console.Write("a) 1912   b) 1913    c) 1909     d) 1980 -->     ");
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
            Console.Write("a) Segunda guerra mundial    b) Primera guerra mundial   c) Muerte de Kenedi     d) Muerte de la Princesa Diana -->      ");
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

        public static void Pregunta5Deportes()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿Qué deporte se creo en Jápón?");
            Console.Write("a) Voley   b) Muay Thai  c) Taekwondo  d) Judo -->    ");
            respuesta = Console.ReadLine();

            if (respuesta == "d" || respuesta == "D")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("No, no, INCORRECTO");
            }

            MsgNextScreen("PRESIONA UNA TECLA PARA VOLVER AL MEN");
        }

        public static void Pregunta4Deportes()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿En donde se creó el fútbol?");
            Console.Write("a) España   b) China  c) Índia  d) Egipto -->    ");
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
                Console.WriteLine("¡¡¡¡¡INCORRECTO!!!!");
            }
        }

        public static void Pregunta3Deportes()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿Y la equitación?");
            Console.Write("a) 1046   b) 1283  c) 1900  d) 1539 -->    ");
            respuesta = Console.ReadLine();

            if (respuesta == "d" || respuesta == "D")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("Que pena, pero es incorrecto");
            }
        }

        public static void Pregunta2Deportes()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿En qué fecha se creó el basquet?");
            Console.Write("a) 1891   b) 1786  c) 1910  d) 1590 -->    ");
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
                Console.WriteLine("No amigo, no");
            }
        }

        public static void Pregunta1Deportes()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿En que deporte la pelota no puede tocar el suelo?");
            Console.Write("a) Basquet   b) Tenis  c) Voley  d) Equitación -->    ");
            respuesta = Console.ReadLine();

            if (respuesta == "c" || respuesta == "C")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("No, no, INCORRECTO");
            }
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

        public static void Pregunta1InstrumentosMusicales()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿Cual es el instrumento más tocado?");
            Console.Write("a) Triángulo   b) Guitarra  c) Piano  d) Flauta -->    ");
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
                Console.WriteLine("Uy uy uy, me da que no");
            }
        }

        public static void Pregunta2InstrumentosMusicales()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("Las maracas son de tipo...");
            Console.Write("a) percusión   b) cuerda  c) eléctrica  d) viento -->    ");
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
                Console.WriteLine("INCORRECTO");
            }
        }

        public static void Pregunta3InstrumentosMusicales()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿Cual de los siguientes instrumentos es de percusión?");
            Console.Write("a) Piano   b) Guitarra Eléctrica  c) Triángulo  d) Flauta -->    ");
            respuesta = Console.ReadLine();

            if (respuesta == "c" || respuesta == "C")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("Ay ay ayyyyyy, NO");
            }
        }

        public static void Pregunta4InstrumentosMusicales()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("¿Cuantos tipos de guirtarras hay?");
            Console.Write("a) 1   b) 4  c) 6  d) 3 -->    ");
            respuesta = Console.ReadLine();

            if (respuesta == "d" || respuesta == "D")
            {
                correcta = true;
            }

            if (correcta)
            {
                Console.WriteLine("Perfecto!!!! ES CORRECTA");
            }
            else
            {
                Console.WriteLine("No, NO, NOOOO");
            }
        }

        private static void Pregunta5InstrumentosMusicales()
        {
            string respuesta;
            bool correcta = false;

            Console.WriteLine("El piano es un instrumento de...");
            Console.Write("a) cuerda   b) viento  c) percusión  d) eléctrico -->    ");
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
                Console.WriteLine("Me temo que es incorrecta tu respuesta");
            }

            MsgNextScreen("PRESIONA UNA TECLA PARA VOLVER AL MEN");
        }
        #endregion
        #endregion

        #region comienzaParteFernando
        public static void FERNANDO1()
        {
            #region preguntasEntrenadores

            int score = 0;

            Console.WriteLine("¿Quién es el entrenador actual del Fc Barcelona?");
            Console.WriteLine("a) Xavi Hernández b) Pep Guardiola c) Frank Heredia d) Carlo Ancelotti");

            string respuestaEntrenadores;
            bool respuestaCorrecta = false;
            do
            {
                respuestaEntrenadores = Console.ReadLine();

                switch (respuestaEntrenadores)
                {
                    case "a":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta = true;
                        score++;
                        break;
                    case "b":
                    case "c":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("\n");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta);

            //PREGUNTA 2
            Console.WriteLine("¿Quién es el entrenador en conseguir 3 CHAMPIONS seguidas?");
            Console.WriteLine("a) Xavi Hernandez b) Zinedine Zidane c) Mourinho d) Cholo Simeone");
            string respuestaEntrenadores2;
            bool respuestaCorrecta2 = false;
            do
            {
                respuestaEntrenadores2 = Console.ReadLine();
                switch (respuestaEntrenadores2)
                {
                    case "b":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta2 = true;
                        score++;
                        break;
                    case "a":
                    case "c":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("\n");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta2);

            //PREGUNTA 3
            Console.WriteLine("¿Quien es el entrenador actual del Real de Madrid? ");
            Console.WriteLine("a) Lionel de Messi b) Ronald Koeman c) Carleto Anchelotti d) Jurggen Klopp");
            string respuestaEntrenadores3;
            bool respuestaCorrecta3 = false;
            do
            {
                respuestaEntrenadores3 = Console.ReadLine();
                switch (respuestaEntrenadores3)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta3 = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("\n");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta3);

            //PREGUNTA 4
            Console.WriteLine("¿Que entrenador a jugado en el Fc Barcelona y ha sido entrenador del Real de Madrid? ");
            Console.WriteLine("a) Pep Guardiola b) Jose Mourinho c) Thierry Henrry d) Mbappe");
            string respuestaEntrenadores4;
            bool respuestaCorrecta4 = false;
            do
            {
                respuestaEntrenadores4 = Console.ReadLine();
                switch (respuestaEntrenadores4)
                {
                    case "b":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta4 = true;
                        score++;
                        break;
                    case "a":
                    case "c":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("\n");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta4);

            //PREGUNTA 5
            Console.WriteLine("¿Cual es el entrenador actual del Sevilla Fc? ");
            Console.WriteLine("a) Quique Sanchez Flores b) Jose Luis Mendilibar c) Julen Lopetegui d) Unai Emery");
            string respuestaEntrenadores5;
            bool respuestaCorrecta5 = false;
            do
            {
                respuestaEntrenadores5 = Console.ReadLine();
                switch (respuestaEntrenadores5)
                {
                    case "a":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta5 = true;
                        score++;
                    break;
                    case "b":
                    case "c":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("\n");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta5);

            Console.WriteLine($"DE LA SECCION ENTRENADORES, HAS SACADO UNA PUNTUACION DE {score}/5");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
            #endregion
        }
        public static void FERNANDO2()
        {
            #region preguntasFutbolistas
            int score = 0;
            int intentosFallidos = 0;

            //PREGUNTA 1:
            Console.WriteLine("¿Quien es el jugador con mas Balones de Oro?");
            Console.WriteLine("a) Cristiano Ronaldo b) Ronaldinho c) Lionel de Messi d) Vini Jr");
            string respuestaFutbolistas;
            bool respuestaCorrecta = false;
            do
            {
                respuestaFutbolistas = Console.ReadLine();

                switch (respuestaFutbolistas)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            respuestaCorrecta = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta);

            //PREGUNTA 2:
            Console.WriteLine("¿Quien es el jugador mas joven en marcar en la Seleccion Española?");
            Console.WriteLine("a) Lamine Yamal b) Ansumane Fati c) Pedri d) Sergio Ramos");
            string respuestaFutbolistas2;
            bool respuestaCorrecta2 = false;
            do
            {
                respuestaFutbolistas2 = Console.ReadLine();

                switch (respuestaFutbolistas2)
                {
                    case "a":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta2 = true;
                        score++;
                        break;
                    case "b":
                    case "c":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                            respuestaCorrecta2 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta2);

            //PREGUNTA 3:
            Console.WriteLine("¿Quien fue el jugador mas caro de la historia?");
            Console.WriteLine("a) Maradona b) Paul Pogba c) Neymar Jr d) Samuel Umtiti");
            string respuestaFutbolistas3;
            bool respuestaCorrecta3 = false;
            do
            {
                respuestaFutbolistas3 = Console.ReadLine();

                switch (respuestaFutbolistas3)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta3 = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                            respuestaCorrecta3 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta3);

            //PREGUNTA 4:
            Console.WriteLine("¿De estos jugadores, quien tiene mas CHAMPIONS?");
            Console.WriteLine("a) Cristiano Ronaldo b) Sergio Ramos c) Neymar Jr d) Mbappé");
            string respuestaFutbolistas4;
            bool respuestaCorrecta4 = false;
            do
            {
                respuestaFutbolistas4 = Console.ReadLine();

                switch (respuestaFutbolistas4)
                {
                    case "a":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta4 = true;
                        score++;
                        break;
                    case "b":
                    case "c":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                            respuestaCorrecta4 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta4);

            //PREGUNTA 5:
            Console.WriteLine("¿Que jugador, jugo en la Juventus y en el Manchester United?");
            Console.WriteLine("a) Ousmane Dembelé b) Bellingham c) Paul Pogba d) Amadu Onana");
            string respuestaFutbolistas5;
            bool respuestaCorrecta5 = false;
            do
            {
                respuestaFutbolistas5 = Console.ReadLine();

                switch (respuestaFutbolistas5)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta5 = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                            respuestaCorrecta5 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta5);

            Console.WriteLine($"DE LA SECCION 'FUTBOLISTAS', HAS SACADO UNA PUNTUACION DE [{score}/5]");
            //Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
            #endregion
        }
        public static void FERNANDO3()
        {
            #region preguntasEstadios
            int score = 0;
            int intentosFallidos = 0;

            //PREGUNTA 1
            Console.WriteLine("¿Como se llama el estadio del Real de Madrid?");
            Console.WriteLine("a) Santiago Bernanbeu b) Camp Nou c) Wanda Metropolitano d) Old Trafford");
            string respuestaEstadios1;
            bool respuestaCorrecta1 = false;
            do
            {
                respuestaEstadios1 = Console.ReadLine();

                switch (respuestaEstadios1)
                {
                    case "a":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta1 = true;
                        score++;
                        break;
                    case "b":
                    case "c":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            respuestaCorrecta1 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta1);

            //PREGUNTA2
            Console.WriteLine("¿Donde se encuentra el estadio del Real Betis Fc?");
            Console.WriteLine("a) Betis b) Barcelona c) Sevilla d) Madrid");
            string respuestaEstadios2;
            bool respuestaCorrecta2 = false;
            do
            {
                respuestaEstadios2 = Console.ReadLine();

                switch (respuestaEstadios2)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta2 = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            respuestaCorrecta2 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta2);

            //PREGUNTA 3
            Console.WriteLine("¿Qué equipo juega como local en el estadio Signal Iduna Parck?");
            Console.WriteLine("a) Fc Bayern Munchen b) Girona Fc c) Borussia Dortmund d) RB Leipzig");
            string respuestaEstadios3;
            bool respuestaCorrecta3 = false;
            do
            {
                respuestaEstadios3 = Console.ReadLine();

                switch (respuestaEstadios3)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta3 = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            respuestaCorrecta3 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta3);

            //PREGUNTA 4
            Console.WriteLine("¿En que sitio se encuentra el estadio del Everton?");
            Console.WriteLine("a) Londres b) Paris c) Berlin d) Liverpol");
            string respuestaEstadios4;
            bool respuestaCorrecta4 = false;
            do
            {
                respuestaEstadios4 = Console.ReadLine();

                switch (respuestaEstadios4)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta4 = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            respuestaCorrecta4 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta4);

            //PREGUNTA 5
            Console.WriteLine("¿Que otro nombre recibe San Mamés, el estadio del Athletic Club?");
            Console.WriteLine("a) El Castillo b) La Muralla c) La Catedral d) La Iglesia");
            string respuestaEstadios5;
            bool respuestaCorrecta5 = false;
            do
            {
                respuestaEstadios5 = Console.ReadLine();

                switch (respuestaEstadios5)
                {
                    case "c":
                        Console.WriteLine("¡RESPUESTA CORRECTA!");
                        Console.WriteLine("\n");
                        respuestaCorrecta5 = true;
                        score++;
                        break;
                    case "a":
                    case "b":
                    case "d":
                        Console.WriteLine("¡TE HAS EQUIVOCADO! :(");
                        Console.WriteLine("Por favor, intenta de nuevo.");
                        intentosFallidos++;
                        if (intentosFallidos >= 3)
                        {
                            Console.Clear();
                            respuestaCorrecta5 = true; // Termina el bucle si excede los dos intentos fallidos
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingresa a, b, c o d.");
                        break;
                }
            } while (!respuestaCorrecta5);

            Console.WriteLine($"DE LA SECCION 'ESTADIOS', HAS SACADO UNA PUNTUACION DE [{score}/5]");
            //Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
            #endregion
        }
        #endregion
    }
}
