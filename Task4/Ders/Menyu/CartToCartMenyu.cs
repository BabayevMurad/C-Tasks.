using Ders.Class;
using Ders.Helpers;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;

namespace Ders.Menyu
{
    public static class CartToCartMenyu {
        
        static public void CartToCart(ref User[] users, ref User user) {

            int colorChoice = 0;

            string[] menyu = ["0.Exit:", "1.Cart Input:"];

            bool condition = true;

            while (condition)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("\tCart To Cart.");

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
                        Choose_Check(ref users, ref user, ref condition, colorChoice);
                        break;
                    default:
                        break;
                }
            }

        }

        static void Choose_Check(ref User[] users, ref User user, ref bool condition, int color_chocie)
        {
            switch (color_chocie)
            {
                case 0:
                    condition = false;
                    break;

                case 1:
                    try
                    {
                        Cart_input(ref users, ref user);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("PAN not found:");

                        Thread.Sleep(1400);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("PAN or PIN input uncorrectly:");

                        Thread.Sleep(1400);

                    }
                    break;

                default:
                    break;
            }
        }

        static void Cart_input(ref User[] users, ref User user) {
            string? PAN;
            string money_str;
            int Test;
            decimal money;
            User user1;

            Console.Write("Input Pan: ");
            PAN = Console.ReadLine();

            Console.Write("Input Money: ");
            money_str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(PAN) && int.TryParse(PAN, out Test))
                throw new Exception("Argument Not Correct:");

            if (string.IsNullOrWhiteSpace(money_str) && int.TryParse(money_str, out Test))
                throw new Exception("Argument Not Correct:");

            money = decimal.Parse(money_str);

            if (!(user.CreditCard.Balance >= money))
                throw new Exception();

            user1 = Serhac(ref users, PAN);

            user1.CreditCard.Balance += money;

            user.CreditCard.Balance -= money;

            Console.WriteLine("Operation Sucseful:");
            Thread.Sleep(1400);
        }

        static User Serhac(ref User[] users, string PAN) {

            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].CreditCard.PAN == PAN)
                    return users[i];
            }
            throw new ArgumentException("User Not Found.");

        }

    }
}
