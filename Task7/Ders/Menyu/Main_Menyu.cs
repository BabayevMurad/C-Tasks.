using Ders.Models;

namespace Ders.Menyu
{
    static public class Main_Menyu
    {
        static public User Menyu(ref User user) {

            string[] menyuChoice = ["Su iç:", "Tarixçə:", "Günü Bitir:", "Çıxış:"];

            bool continiue = true;

            int color_choice = 0;

            while (continiue) {


                Console.Clear();
                Console.ResetColor();

                Console.WriteLine($"Xoş gəldiniz: {user.Name}");
                Console.WriteLine($"Tarix: {user.Date.ToShortDateString()}");
                Console.WriteLine($"Gündəlik Norma: {user.Wather_Norm}Lt");
                Console.WriteLine($"Bugün: {user.Drinked_Wather}Lt");

                for (int i = 0; i < menyuChoice.Length; i++)
                {
                    if (i == color_choice)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(menyuChoice[i]);
                    Console.ResetColor();
                }

                var key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        if (color_choice == 0)
                            color_choice = menyuChoice.Length - 1;
                        else
                            color_choice--;
                        break;
                    case ConsoleKey.S:
                        if (color_choice == menyuChoice.Length - 1)
                            color_choice = 0;
                        else
                            color_choice++;
                        break;
                    case ConsoleKey.Enter:
                        Chooice_Check(ref user, color_choice, ref continiue);
                        break;
                    default:
                        break;
                }
            }

            return user;
        }

        static private void Chooice_Check(ref User user, int color_choice, ref bool continiue)
        {
            switch (color_choice)
            {
                case 0:
                    Logic.Logic.Drink_Wather(ref user);
                    break;
                case 1:
                    Logic.Logic.History(ref user);
                    break;
                case 2:
                    user.End_Day();
                    break;
                case 3:
                    continiue = false;
                    break;
                default:
                    break;
            }
        }
    }
}
