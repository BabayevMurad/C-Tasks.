namespace Ders.Models
{
    public class History
    {
        public DateTime Date { get; set; }
        public double Wather { get; set; }

        public History(DateTime Date, double Wather)
        {
            this.Date = Date;
            this.Wather = Wather;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()}: {Wather}Lt";
        }
    }
}
