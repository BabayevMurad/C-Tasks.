using Ders.Menyu;
using Ders.Models;
using Ders.Streams;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        User user = new("Nes",1);

        if (!File.Exists("User.json"))
        {
            user = Register_Menyu.Menyu();
        }
        else
        {
            user = FileWrite.Read_File();
        }

        User user1 = Main_Menyu.Menyu(ref user);
        FileWrite.Write_File(ref user1);
    }
}