using System.Collections;

namespace ArryList
{
    internal class ArrayList
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);

            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }

            arrayList.Remove(4);

            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
