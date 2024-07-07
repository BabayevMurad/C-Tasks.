namespace Task9
{
    internal class Director
    {
        public void MakeSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine(new Engine());
            builder.SetGPS();
        }

        public void MakeSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new SportEngine());
            builder.SetTripComuter();
            builder.SetGPS();
        }
    }
}
