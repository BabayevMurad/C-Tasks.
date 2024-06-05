using Ders.Class;

namespace Ders.Helpers
{
    public static class BalanceDecrement {

        static public void Balance_decrement(ref User user, decimal money)
        {
            if (user.CreditCard.Balance >= money) {
                user.CreditCard.Balance -= money;
                Console.WriteLine("Operation Sucsesful.");
                Console.WriteLine($"Your Balance Is: {user.CreditCard.Balance}");
                Thread.Sleep(1100);
                
            }
            else
                throw new Exception("Not enought money");
        }

    }
}
