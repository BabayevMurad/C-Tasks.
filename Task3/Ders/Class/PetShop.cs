namespace Ders.Class
{
    public class PetShop {

        List<CatHouseClass> catHouses;

        public int AllCatHouses_Price()
        {
            int price = 0;

            foreach (CatHouseClass cathouse in catHouses)
            {
                price += cathouse.AllCats_Price();
            }

            return price;
        }
        public int AllCatHouses_MealQuantitiy()
        {
            int quantitiy = 0;

            foreach (CatHouseClass cathouse in catHouses)
            {
                quantitiy += cathouse.AllCats_MealQuantitiy();
            }

            return quantitiy;
        }

        public PetShop(List<CatHouseClass> catHouse_input) {

            catHouses = catHouse_input;

        }
    }
}
