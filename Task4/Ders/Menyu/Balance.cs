using Ders.Class;

namespace Ders.Menyu
{
    public static class Balance {
        static public void Balance_Show(ref User user) {
            Console.WriteLine($"Balance: {user.CreditCard.Balance}");
            Thread.Sleep(1200);
        }

    }
}
