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
            Console.WriteLine("1 - CUSTOMERS");
            Console.WriteLine("2 - PROVIDERS");
            Console.WriteLine("3 - INVOICES");
            Console.WriteLine("5 - DATA");
            Console.WriteLine("6 - MCD");
            Console.WriteLine("7 - Hulukulu y Bulukulu");
            Console.WriteLine("8 - Suma de dígitos");
            Console.WriteLine("0 - EXIT");
        }

    }
}