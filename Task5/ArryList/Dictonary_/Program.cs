namespace Dictonary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<float,int> keyValuePairs = new Dictionary<float,int>();

            keyValuePairs.Add(2.7f, 91);
            keyValuePairs.Add(7.9f, 51);
            keyValuePairs.Add(6.7f, 13);

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            keyValuePairs.Remove(13);

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
