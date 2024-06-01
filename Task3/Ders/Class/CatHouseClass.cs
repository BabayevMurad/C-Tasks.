namespace Ders.Class
{

    public class CatHouseClass {
        public string Name { get; set; }

        public List<CatClass> cats;

        public void AddCat(CatClass cat) {
            cats.Add(cat);

            Console.Clear();

            Console.ResetColor();

            Console.WriteLine("Cat Added.");

            Thread.Sleep(1500);
        }
        public void RemoveCat(string nickname) {
            bool have = false;
            CatClass cat_remove = new CatClass();

            foreach (CatClass cat in cats) {
                if (cat.Nickname == nickname) {
                    have = true;
                    cat_remove = cat;
                }    
            }

            if (have) {
                cats.Remove(cat_remove);

                Console.Clear();

                Console.ResetColor();

                Console.WriteLine("Cat Removed.");

                Thread.Sleep(1500);
            }

            else {
                Console.Clear();

                Console.ResetColor();

                Console.WriteLine("Cat Not Found.");

                Thread.Sleep(1500);
            }

        }
        public int AllCats_Price() {
            int price = 0;

            foreach (CatClass cat in cats) {
                price += cat.Price;
            }

            return price;
        }
        public int AllCats_MealQuantitiy()
        {
            int quantitiy = 0;

            foreach (CatClass cat in cats)
            {
                quantitiy += cat.MealQuantitiy;
            }

            return quantitiy;
        }

        public CatHouseClass(string name,List<CatClass> cats_input) {
            cats = cats_input;
            Name = name;
        }
    }

}