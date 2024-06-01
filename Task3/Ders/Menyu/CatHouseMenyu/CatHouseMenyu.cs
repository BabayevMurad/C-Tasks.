using Ders.Class;

namespace Ders.Menyu.CatHouseMenyu
{
    public class CatHouseMenyu {

        static public void Cat_House_Menyu(ref CatHouseClass catHouse)
        {

            string[] menyu = ["0.Back", "1.All Cats", "2.Add Cat", "3.Remove Cat By Nickname"];

            int color_choice = 0;

            bool continiue = true;

            while (continiue)
            {

                Console.Clear();

                Console.ResetColor();

                Console.WriteLine("CatHouse.");

                for (int i = 0; i < menyu.Length; i++)
                {
                    Console.ResetColor();
                    if (i == color_choice)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(menyu[i]);

                }

                var key_1 = Console.ReadKey();

                switch (key_1.Key)
                {
                    case ConsoleKey.W:
                        if (color_choice == 0)
                            color_choice = menyu.Length - 1;
                        else
                            color_choice--;
                        break;
                    case ConsoleKey.S:
                        if (color_choice == menyu.Length - 1)
                            color_choice = 0;
                        else
                            color_choice++;
                        break;
                    case ConsoleKey.Enter:
                        Check_Choose(ref catHouse, color_choice, ref continiue);
                        break;
                    default:
                        break;
                }

            }
        }

        static void Check_Choose(ref CatHouseClass catHouse, int color_choise, ref bool continiue)
        {
            switch (color_choise)
            {
                case 0:
                    continiue = false;
                    break;
                case 1:
                    AllCats.All_Cats_Menyu(ref catHouse);
                    break;
                case 2:
                    CatAdd.Cat_Add(ref catHouse);
                    break;
                case 3:
                    RemoveCatByNickname.Remove_Cat_By_Nickname(ref catHouse);
                    break;
                default:
                    break;
            }
        }

    }
}
