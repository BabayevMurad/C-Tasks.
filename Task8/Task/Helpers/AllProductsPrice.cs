using Task.Models;

namespace Task.Helpers
{
    static public class AllProductsPrice
    {
        public static double AllPrice(List<Product> products)
        {
            double price = 0;

            foreach (var product in products)
            {
                price += product.Price;
            }

            return price;
        }
    }
}
