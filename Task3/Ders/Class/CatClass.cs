namespace Ders.Class
{
    public class CatClass
    {
        public string? Nickname { get; set; }
        public string? Gender { get; set; }
        
        byte age;
        public byte Age {

            get => age;

            set { age = value > 0 ? age = value : age = 0; }
        }

        byte energy = 100;
        public byte Energy {

            get => energy;

            set { energy = value > 0 ? energy = value : energy = 0; }

        }

        ushort price;
        public ushort Price {

            get => price;

            set { price = value > 0 ? price = value : energy = 0; }

        }

        ushort mealQuantitiy = 0;
        public ushort MealQuantitiy {

            get => mealQuantitiy;

            set { mealQuantitiy = value > 0 ? mealQuantitiy = value : mealQuantitiy = 0; }

        }

        public CatClass() {}
        public CatClass(string nickname, string gender, byte age, ushort price)
        {
            Nickname = nickname;
            Gender = gender;
            Age = age;
            Price = price;
            MealQuantitiy = mealQuantitiy;
        }

        public void Eat()
        {
            MealQuantitiy++;
            Price += 1;
            if (Energy != 100)
                Energy += 10;

            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Pişik Yeyir...");

            Thread.Sleep(2000);

        }
        public void Sleep()
        {
            Energy = 100;

            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Pişik Yatır...");

            Thread.Sleep(2000);
        }
        public void Play()
        {
            Energy = Energy > 0 ? Energy -= 5 : (byte)100;

            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Pişik Oynayır...");

            Thread.Sleep(2000);
        }
    }
}
