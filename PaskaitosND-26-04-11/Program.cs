namespace PaskaitosND_26_04_11
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu ===");
                Console.WriteLine("1 - ND1");
                Console.WriteLine("2 - ND2");
                Console.WriteLine("3 - ND3");
                Console.WriteLine("4 - ND4");
                Console.WriteLine("5 - ND5");
                Console.WriteLine("6 - ND6");
                Console.WriteLine("0 - Baigti");
                Console.Write("Pasirinkimas: ");

                string pasirinkimas = Console.ReadLine();

                Console.Clear();

                switch (pasirinkimas)
                {
                    case "1":
                        ND1.Nd1();
                        break;
                    case "2":
                        ND2.Nd2();
                        break;
                    case "3":
                        ND3.Nd3();
                        break;
                    case "4":
                        ND4.Nd4();
                        break;
                    case "5":
                        ND5.Nd5("varadas");
                        break;
                    case "6":
                        ND6.Nd6();
                        break;
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Tokio pasirinkimo nėra.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Paspausk Enter, kad grįžtum į meniu...");
                Console.ReadLine();
            }
        }
    }
}
