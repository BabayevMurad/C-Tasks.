namespace list
{
    internal class list
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("W123");
            list.Add("E34");
            list.Add("RS-2 Avant");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveRange(1, 2);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
