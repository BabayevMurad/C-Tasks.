using System.Collections;

namespace HashTable
{
    internal class HashTable
    {
        static void Main(string[] args) {

            Hashtable hashtable = new Hashtable();

            hashtable.Add(1,"Salam");
            hashtable.Add(2,"Xan");
            hashtable.Add(3,"Oazis");

            foreach (DictionaryEntry element in hashtable)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }

            hashtable.Remove(2);

            foreach (DictionaryEntry element in hashtable)
            {
                Console.WriteLine($"{element.Key} : {element.Value}");
            }
        }
    }
}
