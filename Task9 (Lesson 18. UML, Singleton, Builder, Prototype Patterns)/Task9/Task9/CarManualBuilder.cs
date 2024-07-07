namespace Task9
{
    internal class CarManualBuilder : IBuilder
    {
        Manual Manual = new Manual();

        public void Reset()
        {
            Manual = new Manual();
        }

        public void SetEngine(Engine engine)
        {
            Manual.Engine = engine;
        }

        public void SetGPS()
        {
            Manual.GPS = true;
        }

        public void SetSeats(int number)
        {
            Manual.Seats = number;
        }

        public void SetTripComuter()
        {
            Manual.TripComputer = true;
        }

        public Manual GetResult() => Manual;
    }
}
