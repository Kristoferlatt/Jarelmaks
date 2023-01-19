namespace Liising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pakume järelmaksu 3, 6, 12, 24 kuuks 9% intressiga");

            Console.WriteLine("Palun sisesta järelmaksu summa");
            float firstNr = int.Parse(Console.ReadLine());

            Console.WriteLine("Palun sisesta soovitud tagasimakse kordade arv ( 3, 6, 12, 24 ): ");
            string operation = Console.ReadLine();



            try
            {
                switch (operation)
                {
                    case "3":
                        float resultAdd = firstNr / 3;
                        Console.WriteLine("Teie igakuine makse järgmised 3 kuud on: " + resultAdd * 1.09 + " Eurot");
                        break;

                    default:
                        break;

                }
                switch (operation)
                {
                    case "6":
                        float resultAdd = firstNr / 6;
                        Console.WriteLine("Teie igakuine makse järgmised 6 kuud on: " + resultAdd * 1.09 + " Eurot");
                        break;

                    default:
                        break;

                }
                switch (operation)
                {
                    case "12":
                        float resultAdd = firstNr / 12;
                        Console.WriteLine("Teie igakuine makse järgmised 12 kuud on: " + resultAdd * 1.09 + " Eurot");
                        break;

                    default:
                        break;

                }
                switch (operation)
                {
                    case "24":
                        float resultAdd = firstNr / 24;
                        Console.WriteLine("Teie igakuine makse järgmised 24 kuud on: " + resultAdd * 1.09 + " Eurot");
                        break;

                    default:
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Vale numbri formaat.");
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur.");
            }
        }
    }
}

