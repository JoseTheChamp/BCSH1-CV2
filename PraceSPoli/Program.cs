using Fei.BaseLib;

namespace Fei {


    class PraceSPolem
    {
        static int[] pole = new int[50];
        static int delka = 0;

        static void Main(string[] args)
        {
            bool pokracuj = true;
            while (pokracuj)
            {
                Console.WriteLine("-------------------------------------------------------------");
                String operace = Reading.ReadString("Zadejte jednu z následujících operací:\n" +
                    "1) Zadej prvek z klavesnice.\n" +
                    "2) Vypiš pole.\n" +
                    "3) Utřiď pole vzestupně.\n" +
                    "4) Utřiď pole vzestupně.\n" +
                    "5) Najdi minimální prvek.\n" +
                    "6) Najdi první výskyt prvku.\n" +
                    "7) Najdi poslední výskyt prvku.\n" +
                    "8) Konec programu.\n" +
                    "Vaše volba");
                Console.WriteLine("-------------------------------------------------------------");
                switch (operace)
                {
                    case "1": // Prida prvek do pole zadany z klavesnice.
                        PridatPrvek();
                        break;
                    case "2": //Vypise obsah pole.
                        VypisPole();
                        break;
                    case "3": //Utridi pole vzestupne.
                        UtridVzestupne();
                        break;
                    case "4": // Utridi pole sestupne.
                        UtridSestupne();
                        break;
                    case "5": //Najde nejmensi prvek v poli
                        NajdiMinPrvek();
                        break;
                    case "6": //Najde prvni vyskyt prvku zadany z klavesnice.
                        NajdiPrvniVyskyt();
                        break;
                    case "7": //Najde posledni vyskyt prvku zadany z klavesnice.
                        NajdiPosledniVyskyt();
                        break;
                    case "8": //konec programu
                        pokracuj = false;
                        Console.WriteLine("Konec programu.");
                        break;
                    default:
                        Console.WriteLine("Zadané číslo neodpovída operaci.");
                        break;
                }
            }
        }

        private static void NajdiPosledniVyskyt()
        {
            try
            {
                Console.WriteLine("Zadání hledaneho prvku z klávesnice.");
                int vstup = Reading.ReadInt("Zadejte celé číslo:  ");
                int pozice = -1;
                for (int i = 0; i < delka; i++)
                {
                    if (pole[i] == vstup)
                    {
                        pozice = i;
                    }
                }
                if (pozice != -1)
                {
                    Console.WriteLine("Posledni vyskyt cisla " + vstup + " je na pozici: " + (pozice + 1));
                }
                else
                {
                    Console.WriteLine("Prvek v poli neni.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void NajdiPrvniVyskyt()
        {
            try
            {
                Console.WriteLine("Zadání hledaneho prvku z klávesnice.");
                int vstup = Reading.ReadInt("Zadejte celé číslo:  ");
                bool nasel = false;
                for (int i = 0; i < delka; i++)
                {
                    if (pole[i] == vstup)
                    {
                        Console.WriteLine("Prvni vyskyt cisla " + vstup + " je na pozici: " + (i + 1));
                        nasel = true;
                        break;
                    }
                }
                if (!nasel)
                {
                    Console.WriteLine("Prvek v poli neni.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void NajdiMinPrvek()
        {
            if (delka == 0)
            {
                Console.WriteLine("Pole je prazdne.");
            }
            else {
                int min = pole[0];
                for (int i = 0; i < delka; i++)
                {
                    if (pole[i]<min)
                    {
                        min = pole[i];
                    }
                }
                Console.WriteLine("Nejmensi prvek je: " + min);
            }
            
        }

        private static void UtridVzestupne()
        {
            Console.WriteLine("Pole je setridene vzestupne.");
            Array.Sort(pole,0,delka);
        }

        private static void UtridSestupne()
        {
            Console.WriteLine("Pole je setridene sestupne.");
            Array.Reverse(pole, 0, delka);
        }

        private static void VypisPole()
        {
            Console.WriteLine("Toto je vaše pole.");
            for (int i = 0; i < delka; i++)
            {
                Console.WriteLine(pole[i]);
            }
        }

        private static void PridatPrvek()
        {
            try
            {
                Console.WriteLine("Zadání prvku z klávesnice.");
                pole[delka] = Reading.ReadInt("Zadejte celé číslo:  ");
                delka++;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void PridatPrvek2()
        {
            Console.WriteLine("Zadání prvku z klávesnice.");
            Console.WriteLine("Zadejte celé číslo:  ");
            String vstup = Console.ReadLine();
            if (int.TryParse(vstup, out int result))
            {
                pole[delka] = result;
                delka++;
            }
            else
            {
                Console.WriteLine("Nezadali jste platne cislo.");
            }
        }

    }








}
