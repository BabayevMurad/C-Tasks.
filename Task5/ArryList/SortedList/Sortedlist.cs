using System.Collections;

namespace Sortedlist
{
    internal class Sortedlist
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add("Car", "Black");
            sortedList.Add("C#", "Normal Language");
            sortedList.Add("C++", "Devil Language");
            sortedList.Add("Future", "Back");

            foreach (DictionaryEntry element in sortedList)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }

            sortedList.Remove("Car");
            sortedList.Remove("C++");

            foreach (DictionaryEntry element in sortedList)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }

            SortedList<char,int> sortedList2 = new SortedList<char,int>();
            sortedList2.Add('A', 2);
            sortedList2.Add('B', 3);
            sortedList2.Add('C', 4);
            sortedList2.Add('D', 5);

            foreach (var element2 in sortedList2)
            {
                Console.WriteLine($"{element2.Key} : {element2.Value}");
            }

            sortedList2.Remove('B');
            sortedList2.Remove('C');

            foreach (var element2 in sortedList2)
            {
                Console.WriteLine($"{element2.Key} : {element2.Value}");
            }
        }
    }
}
