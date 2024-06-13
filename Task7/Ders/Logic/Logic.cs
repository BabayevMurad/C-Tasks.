using Ders.Models;

namespace Ders.Logic
{
    static public class Logic
    {
        static public void Drink_Wather(ref User user)
        {
            Start:
            bool condition;
            double wather = 0;

            condition = false;

            Console.Clear();
            Console.ResetColor();

            Console.Write("İçdiyiniz Suyu Daxil Edin: ");

            string wather_str = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(wather_str))
            {
                condition = double.TryParse(wather_str, out wather);
            }

            if (!condition)
            {
                Console.WriteLine("Xais Olunur Düzgun Daxil Edin:");
                Thread.Sleep(1000);
                goto Start;
            }

            Console.WriteLine($"Siz {wather} litir su içdiniz.");
            Thread.Sleep(1000);

            user.Wather_Drink(wather);

            return;
        }

        static public void History(ref User user)
        {
            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Tarixçə:");

            for (int i = 0; i < user.history.Count; i++)
            {
                Console.WriteLine(user.history[i]);
            }
            Console.WriteLine("Çıxmaq Üçün İstənilən Button Basın:");

            Console.ReadKey();
        }

    }
}
