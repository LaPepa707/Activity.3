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
                        YARYNA();
                        break;
                    case ConsoleKey.D2:
                        FERNANDO();
                        break;
                    case ConsoleKey.D3:
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
            Console.WriteLine("10 - HISTORIA");
            Console.WriteLine("0 - EXIT");
        }

    }
}