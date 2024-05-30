using System.Globalization;
using System.Text;

namespace Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double number_1;
            double number_2;
            double answer = 0.0;
            bool cast_1;
            ConsoleKeyInfo key;

            NumberFormatInfo number_format = new NumberFormatInfo()
            {

                NumberDecimalSeparator = ".",

            };

            while (true)
            {

                Console.Clear();


                Console.Write("Birinci Ədədi Daxil Edin: ");

                cast_1 = double.TryParse(Console.ReadLine(), out number_1);

                if (!cast_1)
                {

                    Console.WriteLine("Düzgun Daxil Edin: ");

                    Thread.Sleep(1500);

                    continue;

                }

                Console.Write("Operasiyanı Edin: ");

                key = Console.ReadKey();

                if (!(key.KeyChar == '+' || key.KeyChar == '-' || key.KeyChar == '*' || key.KeyChar == '/' || key.Key == ConsoleKey.Escape))
                {

                    Console.WriteLine("");
                    Console.WriteLine("Düzgun Daxil Edin: ");

                    Thread.Sleep(1500);

                    continue;

                }

                Console.WriteLine(key.KeyChar);

                Console.Write("İninci Ədədi Daxil Edin: ");

                bool cast_2 = double.TryParse(Console.ReadLine(), out number_2);

                if (!cast_2)
                {

                    Console.WriteLine("Düzgun Daxil Edin: ");

                    Thread.Sleep(1500);

                    continue;

                }

                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        return;

                    case ConsoleKey.Add:
                        answer = Math.Function.Sum(number_1, number_2);
                        break;

                    case ConsoleKey.Subtract:
                        answer = Math.Function.Subtract(number_1, number_2);
                        break;

                    case ConsoleKey.Multiply:
                        answer = Math.Function.Multiply(number_1, number_2);
                        break;

                    case ConsoleKey.Divide:
                        answer = Math.Function.Divide(number_1, number_2);
                        break;

                    default:
                        break;
                }

                Console.WriteLine($"Cavab : {answer}");

                Thread.Sleep(1000);

            }

        }
    }
}

namespace Math
{
    class Function
    {

        public static double Sum(double number_1, double number_2)
        {
            return number_1 + number_2;
        }

        public static double Subtract(double number_1, double number_2)
        {
            return number_1 - number_2;
        }

        public static double Multiply(double number_1, double number_2)
        {
            return number_1 * number_2;
        }
        public static double Divide(double number_1, double number_2)
        {
            return number_1 / number_2;
        }

    }

}