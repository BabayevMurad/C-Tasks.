using Ders.Class;

namespace Ders.Menyu
{
    public static class EnterMenyu {

        public static void Menyu(ref User[] users) {

            int colorChoice = 0;

            string[] menyu = ["0.Exit:", "1.PAN Input:"];   

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("\tBank.");

                

                for (int i = 0; i < menyu.Length; i++) {
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
                        Choose_Check(ref users, colorChoice);
                        break;
                    default:
                        break;
                }
            }

        } 
    
        static void Choose_Check(ref User[] users,int colorChoice) {
            switch (colorChoice)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    try
                    {
                        PIN_Input_Menyu(ref users);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("PAN or PIN input uncorrectly:");

                        Thread.Sleep(1400);

                        return;
                    }
                    break;
                default:
                    break;
            }
        }

        static void PIN_Input_Menyu(ref User[] users) {
            int Test;

            Console.Write("PAN: ");
            string? PAN = Console.ReadLine();

            Console.Write("PIN: ");
            string? PIN = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(PAN) && int.TryParse(PAN, out Test))
                throw new Exception("Argument Not Correct:");

            if (string.IsNullOrWhiteSpace(PIN) && int.TryParse(PIN, out Test))
                throw new Exception("Argument Not Correct:");

            try
            {
                Serhac(ref users, PIN);
            }
            catch (Exception)
            {
                Console.WriteLine("Inputed PAN or PIN doesn't correct:");

                Thread.Sleep(1400);

                return;
            }
        } 

        static void Serhac(ref User[] users, string? PIN) {
            bool condition = true;
            for (int i = 0; i < users.Length; i++) {
                if (users[i].CreditCard.PIN == PIN) {
                    condition = UserMenyu.User_Menyu(ref users ,ref users[i]);
                    if (!condition)
                        return;
                }
            }
            throw new Exception("User Not Found.");
        }
    }
}
