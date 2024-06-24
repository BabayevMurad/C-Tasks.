namespace Task.Models;

public class User
{
    public string Name { get; set; }
    public string Login { get; set; }
    public string Pasword { get; set; }
    public List<Product> Basket { get; set; }

    public User() { }
    public User(string name, string login, string pasword, List<Product> basket) { Name = name; Login = login; Pasword = pasword; Basket = basket; }

    public bool Equal(ref User user)
    {
        if (Login == user.Login && Pasword == user.Pasword) {  return true; }

        return false;
    }
}
