using Ders.Class;

namespace Ders.Menyu.CatHouseMenyu
{
    public class CatAdd {

        static public void Cat_Add(ref CatHouseClass catHouse) {
            string? nickname, gender, age_str, price_str;
            byte age;
            ushort price;

            Console.Clear();

            Console.ResetColor();

            Console.Write("Cat Add: ");
            
            Console.Write("Cat NickName: ");
            nickname = Console.ReadLine();

            Console.Write("Cat Gender: ");
            gender = Console.ReadLine();

            Console.Write("Cat Age: ");
            age_str = Console.ReadLine();

            Console.Write("Cat Price: ");
            price_str = Console.ReadLine();

            if (!byte.TryParse(age_str, out age)) {
                Console.Clear();

                Console.WriteLine("Pleace Input Correctly.");

                Thread.Sleep(1000);

                return;
            }

            if (!ushort.TryParse(price_str, out price))
            {
                Console.Clear();

                Console.WriteLine("Pleace Input Correctly.");
                
                Thread.Sleep(1000);
                
                return;
            }

            if (nickname == null)
                nickname = "";

            if (gender == null)
                gender = "";

            catHouse.AddCat(new CatClass(nickname,gender,age,price));
        }        

    }
}
