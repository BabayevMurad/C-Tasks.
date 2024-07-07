namespace Task9
{
    internal interface IBuilder
    {
        public void Reset();

        public void SetSeats(int number);

        public void SetEngine(Engine engine);

        public void SetTripComuter();

        public void SetGPS();
    }
}
