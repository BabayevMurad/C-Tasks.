using Ders.Models;
using static System.Reflection.Metadata.BlobBuilder;
using System.Text.Json;

namespace Ders.Streams
{
    static public class FileWrite
    {
        static public void Write_File(ref User user) {

            var json = JsonSerializer.Serialize(user);

            File.WriteAllText("User.json", json);
        }

        static public User Read_File()
        {
            var Json = File.ReadAllText("User.json");

            return JsonSerializer.Deserialize<User>(Json);
        }
    }
}
