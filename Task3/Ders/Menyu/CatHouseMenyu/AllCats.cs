using Ders.Class;

namespace Ders.Menyu.CatHouseMenyu
{
    public class AllCats {

        static public void All_Cats_Menyu(ref CatHouseClass catHouse)
        {

            int color_choice = 0;

            bool continiue = true;

            while (continiue)
            {

                Console.Clear();

                Console.ResetColor();

                Console.WriteLine("CatHouse.");

                for (int i = 0; i < catHouse.cats.Count + 1; i++)
                {
                    Console.ResetColor();
                    if (i == color_choice)
                        Console.ForegroundColor = ConsoleColor.Green;

                    if (i == 0)
                    {
                        Console.WriteLine("0.Exit");
                        continue;
                    }

                    Console.WriteLine($"{i}.{catHouse.cats[i - 1].Nickname}");

                }

                var key_1 = Console.ReadKey();

                switch (key_1.Key)
                {
                    case ConsoleKey.W:
                        if (color_choice == 0)
                            color_choice = catHouse.cats.Count;
                        else
                            color_choice--;
                        break;
                    case ConsoleKey.S:
                        if (color_choice == catHouse.cats.Count)
                            color_choice = 0;
                        else
                            color_choice++;
                        break;
                    case ConsoleKey.Enter:
                        if (color_choice != 0)
                        {
                            CatClass cat = catHouse.cats[color_choice - 1];
                            Check_Choose_All_Cats(ref cat, color_choice, ref continiue);
                        }
                        else {
                            Check_Choose_All_Cats(color_choice, ref continiue);
                        }
                        break;
                    default:
                        break;
                }

            }
        }
        static public void Check_Choose_All_Cats(ref CatClass cat, int color_choise, ref bool continiue)
        {
            if (color_choise == 0) { continiue = false; return; }

            CatMenyu.Cat_Menyu(ref cat);
        }

        static public void Check_Choose_All_Cats(int color_choise, ref bool continiue)
        {
            if (color_choise == 0) { continiue = false; return; }
        }

    }
}
