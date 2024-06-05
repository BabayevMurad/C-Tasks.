using Ders.Class;

namespace Ders.Menyu
{
    public static class UserMenyu {

        public static bool User_Menyu(ref User[] users ,ref User user) {

            string[] menyu = ["0.Exit", "1.Balance", "2.Cash Out", "3.Card to Cart"];

            int colorChoice = 0;

            bool condition = true;

            while (condition) {

                Console.Clear();
                Console.ResetColor();

                Console.WriteLine($"Welcome {user.Name} {user.Surname}");

                for (int i = 0; i < menyu.Length; i++) {

                    if (colorChoice == i)
                        Console.ForegroundColor = ConsoleColor.Green;
                
                    Console.WriteLine(menyu[i]);

                    Console.ResetColor();
                }

                var kod = Console.ReadKey();

                switch (kod.Key)
                {
                    case ConsoleKey.W:
                        if (colorChoice != 0)
                            colorChoice--;
                        else
                            colorChoice = menyu.Length-1;
                        break;

                    case ConsoleKey.S:
                        if (colorChoice != menyu.Length-1)
                            colorChoice++;
                        else
                            colorChoice = 0;
                        break;

                    case ConsoleKey.Enter:
                        Menyu_Check(ref users ,ref user, ref condition, colorChoice);
                        break;
                    default:
                        break;
                }
            }

            return condition;
        }

        static void Menyu_Check(ref User[] users,ref User user, ref bool condition, int colorChoice) {
            switch (colorChoice) {
                case 0:
                    condition = false;
                    return;
                case 1:
                    Balance.Balance_Show(ref user);
                    break;
                case 2:
                    try
                    {
                        CashOutMenyu.Cash_Out(ref user);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Not Enought Money In Balance:");
                        Thread.Sleep(1500);
                        return;
                    }
                    break;
                case 3:
                    CartToCartMenyu.CartToCart(ref users, ref user);
                    break;
                default:
                    break;

            }
        }



    }
}
