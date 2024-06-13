namespace Ders.Models
{
    public class User
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Wather_Norm { get; set; }
        public double Drinked_Wather { get; set; } = 0;
        public DateTime Date { get; set; } = DateTime.Now;

        public List<History> history { get; set; }

        User() { }

        public User(string name, double weight)
        {
            Name = name;
            Weight = weight;
            Wather_Norm = weight/20;

            history = new List<History>();

            history.Add(new History(Date,Drinked_Wather));
        }

        public void Wather_Drink(double wather) {
            Drinked_Wather += wather;
            history.Last().Wather += wather;
        }

        public void End_Day()
        {
            if (Drinked_Wather == Wather_Norm)
            {
                Console.WriteLine("Təbriklər siz gündəlik normaya çatdınız.");
                Thread.Sleep(1400);
            }
            else if (Drinked_Wather < Wather_Norm)
            {
                Console.WriteLine("Az su içmisiniz diqqətli olun.");
                Thread.Sleep(1400);
            }
            else 
            {
                Console.WriteLine("Çox su içmisiniz bu ziyandı olun.");
                Thread.Sleep(1400);
            }

            Drinked_Wather = 0;
            history.Add(new History(Date, Drinked_Wather));
            Date.AddDays(1);
        }

    }
}
