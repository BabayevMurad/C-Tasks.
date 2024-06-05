using Ders.Class;
using Ders.Menyu;

namespace Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User[] users = [
                new User("Murad", "Babayev", new CreditCard("1976420891049731", "8412", "617", new DateTime(2029, 6, 1), 500)),
                new User("Naib", "Cavidov", new CreditCard("7375169405712398", "3106", "157", new DateTime(2027, 11, 1), 250)),
                new User("Fuad", "Hamidov", new CreditCard("9108731698503174", "5917", "840", new DateTime(2030,5,1), 1500)),
                new User("Xavi", "Hernandez", new CreditCard("1097632487513908", "1563", "649", new DateTime(2028,7,1), 420)),
                new User("Ilon", "Mask", new CreditCard("5976128753216570", "6789", "429", new DateTime(2025,7,1), 610)),
            ];

            EnterMenyu.Menyu(ref users);
        }
    }
}