using Ders.Class;
using Ders.Menyu.CatHouseMenyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Menyu
{
    internal class CatMenyu {
        static public void Cat_Menyu(ref CatClass cat) {
            string[] menyu = ["0.Back", "1.Eat", "2.Sleep", "3.Play"];

            int color_choice = 0;

            bool continiue = true;

            while (continiue)
            {

                Console.Clear();

                Console.ResetColor();

                Console.WriteLine("Cat.");
                Console.WriteLine($"Cat Energy: {cat.Energy}");
                Console.WriteLine($"Cat Meal_Quantitiy: {cat.MealQuantitiy}");

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
                        Choose_Control(ref cat, color_choice, ref continiue);
                        break;
                    default:
                        break;
                }

            }
        }
        static void Choose_Control(ref CatClass cat, int color_choice, ref bool continiue) {
            switch (color_choice)
            {
                case 0:
                    continiue = false;
                    break;
                case 1:
                    cat.Eat();
                    break;
                case 2:
                    cat.Sleep();
                    break;
                case 3:
                    cat.Play();
                    break;
                default:
                    break;
            }
        }
    }
}
