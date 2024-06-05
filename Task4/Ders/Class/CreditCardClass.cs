namespace Ders.Class
{
    public class CreditCard {

        public string? PAN { get; set; }
        public string? PIN{ get; set; }
        public string? CVC { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Balance { get; set; } = 0;

        public CreditCard() { }
        public CreditCard(string PAN, string PIN, string CVC, DateTime ExpireDate, decimal Balance) {
            this.PAN = PAN;
            this.PIN = PIN;
            this.CVC = CVC;
            this.ExpireDate = ExpireDate;
            this.Balance = Balance;
        }
        public CreditCard(string PAN, string PIN, string CVC, DateTime ExpireDate)
        {
            this.PAN = PAN;
            this.PIN = PIN;
            this.CVC = CVC;
            this.ExpireDate = ExpireDate;
        }
        public override string ToString() {
            return $"Pan: {PAN} Pin: {PIN} Cvc: {CVC} ExpireDate: {ExpireDate.ToString("MM/yy")}";
        }
    }
}
