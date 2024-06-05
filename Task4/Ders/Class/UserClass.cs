namespace Ders.Class
{
    public class User {
    
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public CreditCard? CreditCard { get; set; }
    

        public User() { }

        public User(string Name, string Surname, CreditCard CreditCard) { 
        
            this.Name = Name;
            this.Surname = Surname;
            this.CreditCard = CreditCard;
        }
        public override string ToString() {
            return $"Name: {Name} Surname: {Surname} CreditCard: {CreditCard}";
        }
    }
}
