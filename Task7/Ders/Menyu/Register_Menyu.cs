using Ders.Models;

namespace Ders.Menyu
{
    static public class Register_Menyu
    {
        static public User Menyu()
        {
            string name;
            string weight_str;
            double weight;

            First:

            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Programa Xoş Gəlmisiniz.");

            Console.Write("Xaiş Olunur Aınızı Daxil Edin: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name)) 
            {
                Console.WriteLine("Xais Olunur Duzgun Daxil Edin.");
                Thread.Sleep(1500);
                goto First;
            }

            Console.Write("Xaiş Olunur Çəkinizi Daxil Edin: ");
            weight_str = Console.ReadLine();

            if (!double.TryParse(weight_str, out weight)) 
            {
                Console.WriteLine("Xais Olunur Duzgun Daxil Edin.");
                Thread.Sleep(1500);
                goto First;
            }

            return new User(name, weight); 
        }

    }
}
