using Ders.Class;
using Ders.Menyu;

namespace Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatHouseClass[] catHouses = {

                new CatHouseClass("Holy", new List<CatClass> {new CatClass("Wifi","Famale",5,300),new CatClass("Lan","Mmale",1,200),new CatClass("Wan","Male",2,350)}),

                new CatHouseClass("Jane",new List<CatClass> {new CatClass("Can","Famale",5,300),new CatClass("C++","Mmale",1,200),new CatClass("Python","Male",2,350)}),

            };

            FirstMenyu.Pet_House(ref catHouses);
        }

    }
}