namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            CarBuilder builder = new CarBuilder();
            director.MakeSportsCar(builder);
            Car car = builder.GetResult();
        }
    }
}
