using Ders.Class;
using Ders.Helpers;

namespace Ders.Menyu
{
    public static class CashOutMenyu {
    
        public static void Cash_Out(ref User user) {

            if (user.CreditCard.Balance == 0) {
                throw new Exception("Not eought balance.");
            }

            string[] menyu = ["0: Exit", "1: 10", "2: 20", "3: 50", "4: 100", "5: User input"];

            int colorChoice = 0;

            bool condition = true;

            while (condition)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("\t\tBank.");


                for (int i = 0; i < menyu.Length; i++)
                {
                    if (i == colorChoice)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(menyu[i]);

                    Console.ResetColor();
                }

                ConsoleKeyInfo kod = Console.ReadKey();

                switch (kod.Key)
                {
                    case ConsoleKey.W:
                        if (!(colorChoice == 0))
                            colorChoice--;
                        else
                            colorChoice = menyu.Length - 1;
                        break;

                    case ConsoleKey.S:
                        if (!(colorChoice == menyu.Length - 1))
                            colorChoice++;
                        else
                            colorChoice = 0;
                        break;

                    case ConsoleKey.Enter:
                        try
                        {
                            Choose_Check(ref user, ref condition, colorChoice);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Not Enought Money In Balance:");
                            Thread.Sleep(1500);
                        }
                        break;
                    default:
                        break;

                }
            }
        }

        static void Choose_Check(ref User user, ref bool condition, int color_chocie) {
            switch (color_chocie)
            {
                case 0:
                    condition = false;
                    break;

                case 1:
                    BalanceDecrement.Balance_decrement(ref user, 10);
                    break;

                case 2:
                    BalanceDecrement.Balance_decrement(ref user, 20);
                    break;

                case 3:
                    BalanceDecrement.Balance_decrement(ref user, 50);
                    break;

                case 4:
                    BalanceDecrement.Balance_decrement(ref user, 100);
                    break;

                case 5:
                    User_Choose_Input(ref user);
                    break;

                default:
                    break;
            }
        }

        static void User_Choose_Input(ref User user) {
            string? money_input;
            decimal money = 0;

            Console.Write("Money: ");
            money_input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(money_input) && decimal.TryParse(money_input, out money))
                throw new Exception("Argument Not Correct:");

            money = decimal.Parse(money_input);

            BalanceDecrement.Balance_decrement(ref user, money);
        }

    }
}
