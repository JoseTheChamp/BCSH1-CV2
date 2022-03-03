namespace Fei.BaseLib
{
    public class Reading
    {
        /// <summary>
        /// Tato metoda načte Int
        /// </summary>
        /// <param name="prompt">promt se vypíše jako:  "prompt:  "</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Vyvolá se pokud uzivatel zada nevyhovujíci hodnotu.</exception>
        public static int ReadInt(String prompt)
        {
            System.Console.WriteLine(prompt + ":  ");
            String vstup = Console.ReadLine();
            return int.TryParse(vstup, out int result) ? result : throw new ArgumentException("Zadane cislo nebylo int.");
        }

        /// <summary>
        /// Tato metoda načte Double
        /// </summary>
        /// <param name="prompt">promt se vypíše jako:  "prompt:  "</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Vyvolá se pokud uzivatel zada nevyhovujíci hodnotu.</exception>
        public static double ReadDouble(String prompt)
        {
            System.Console.WriteLine(prompt + ":  ");
            String vstup = Console.ReadLine();
            return double.TryParse(vstup, out double result) ? result : throw new ArgumentException("Zadane cislo nebylo double.");
        }
        /// <summary>
        /// Tato metoda načte String
        /// </summary>
        /// <param name="prompt">promt se vypíše jako:  "prompt:  "</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Vyvolá se pokud uzivatel zada nevyhovujíci hodnotu.</exception>
        public static string ReadString(String prompt)
        {
            System.Console.WriteLine(prompt + ":  ");
            return Console.ReadLine();
        }
        /// <summary>
        /// Tato metoda načte Char
        /// </summary>
        /// <param name="prompt">promt se vypíše jako:  "prompt:  "</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Vyvolá se pokud uzivatel zada nevyhovujíci hodnotu.</exception>
        public static char ReadChar(String prompt)
        {
            System.Console.WriteLine(prompt + ":  ");
            String vstup = Console.ReadLine();
            return char.TryParse(vstup, out char result) ? result : throw new ArgumentException("Zadane cislo nebylo char.");
        }
    }
}