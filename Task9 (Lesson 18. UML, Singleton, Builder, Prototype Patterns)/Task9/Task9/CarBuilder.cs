namespace Task9
{
    internal class CarBuilder : IBuilder
    {
        Car Car = new Car();

        public void Reset()
        {
            Car = new Car();
        }

        public void SetEngine(Engine engine)
        {
            Car.Engine = engine;
        }

        public void SetGPS()
        {
            Car.GPS = true;
        }

        public void SetSeats(int number)
        {
            Car.Seats = number;
        }

        public void SetTripComuter()
        {
            Car.TripComputer = true;
        }

        public Car GetResult() => Car;
    }
}
