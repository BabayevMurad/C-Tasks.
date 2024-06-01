using Ders.Class;

namespace Ders.Menyu
{
    public class FirstMenyu {

        static public void Pet_House(ref CatHouseClass[] catHouses) {

            int color_choice_1 = 0;

            while (true)
            {

                Console.Clear();

                Console.ResetColor();

                Console.WriteLine("PetHouse.");

                Console.WriteLine($"All Eated_Meal: {All_Houses_Meal_Quantity(catHouses)}");
                Console.WriteLine($"All Cats Price: {All_Houses_Price(catHouses)}");


                for (int i = 0; i < catHouses.Length + 1; i++)
                {
                    Console.ResetColor();
                    if (i == color_choice_1)
                        Console.ForegroundColor = ConsoleColor.Green;

                    if (i == 0)
                    {
                        Console.WriteLine("0.Exit");
                        continue;
                    }

                    Console.WriteLine($"{i}.{catHouses[i - 1].Name}");

                }

                var key_1 = Console.ReadKey();

                switch (key_1.Key)
                {
                    case ConsoleKey.W:
                        if (color_choice_1 == 0)
                            color_choice_1 = catHouses.Length;
                        else
                            color_choice_1--;
                        break;
                    case ConsoleKey.S:
                        if (color_choice_1 == catHouses.Length)
                            color_choice_1 = 0;
                        else
                            color_choice_1++;
                        break;
                    case ConsoleKey.Enter:
                        Check_Choose(ref catHouses, color_choice_1);
                        break;
                    default:
                        break;
                }

            }
        }

        static void Check_Choose(ref CatHouseClass[] catHouses, int color_choise)
        {
            if (color_choise == 0) { System.Environment.Exit(0); }

            CatHouseMenyu.CatHouseMenyu.Cat_House_Menyu(ref catHouses[color_choise - 1]);

        }

        static int All_Houses_Meal_Quantity(CatHouseClass[] catHouses) {
            int AllmealQuantity = 0;

            for (int i = 0; i < catHouses.Length; i++) {
                AllmealQuantity += catHouses[i].AllCats_MealQuantitiy();
            }
            
            return AllmealQuantity;
        }

        static int All_Houses_Price(CatHouseClass[] catHouses)
        {
            int Allprice = 0;

            for (int i = 0; i < catHouses.Length; i++)
            {
                Allprice += catHouses[i].AllCats_Price();
            }

            return Allprice;
        }
    }
}
