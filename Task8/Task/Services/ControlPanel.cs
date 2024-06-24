using System.Text.Json;
using Task.Helpers;
using Task.Models;

namespace Task.Login
{
    public class ControlPanel
    {
        List<User> Users { get; set; }

        User? User { get; set; }

        List<Category> Mehsul { get; set; } = new List<Category> {
            new Category("Un", new List<Product> {
                new Product("Çörək", 0.55, "Ağ Çörək."),
                new Product("Çörək", 1, "Qara Çörək."),
                new Product("Bulka", 0.6, "Kişmişli."),
            }),
            new Category("Süd", new List<Product> {
                new Product("Süd", 1.2, "15% 1L."),
                new Product("Pendir", 0.9, "İvanovka."),
                new Product("Yağ", 16, "Kərə."),
            }),
        };

        public ControlPanel()
        {
            FileRead();
        }

        void FileRead()
        {
            if (File.Exists("Users.json"))
            {
                string users = File.ReadAllText("Users.json");

                Users = JsonSerializer.Deserialize<List<User>>(users);
            }
            else
                Users = new List<User>();

        }

        void FileWrite()
        {
            var json = JsonSerializer.Serialize(Users);

            File.WriteAllText("Users.json", json);
        }

        public void Menyu1()
        {
            int colorChoice = 0;
            ConsoleKeyInfo key;
            string[] menyu = { "Exit.", "Login.", "Register." };

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("\t\t\tMenyu");

                for (int i = 0; i < menyu.Length; i++)
                {

                    if (colorChoice == i)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(menyu[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        if (colorChoice > 0)
                            colorChoice--;
                        else colorChoice = menyu.Length;
                        break;
                    case ConsoleKey.S:
                        if (colorChoice < menyu.Length)
                            colorChoice++;
                        else colorChoice = 0;
                        break;
                    case ConsoleKey.Enter:
                        switch (colorChoice)
                        {
                            case 0:
                                FileWrite();
                                System.Environment.Exit(0);
                                break;
                            case 1:
                                if (Login()) { return; }
                                break;
                            case 2:
                                Register();
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        bool Login()
        {
        Start:

            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("\t\t\tLogin");

            Console.WriteLine("Əvvələ Qayıtmaq Üçün ESC basın.");

            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.Escape)
            {
                User = null;
                return false;
            }

            Console.Write("Login: ");
            var login = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(login))
            {
                Console.WriteLine("Xaiş olunur düzgün daxil edin.");
                Thread.Sleep(1200);
                goto Start;
            }

            Console.Write("Password: ");
            var password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Xaiş olunur düzgün daxil edin.");
                Thread.Sleep(1200);
                goto Start;
            }

            var user1 = new User() { Login = login.ToLower(), Pasword = password };

            User user2 = null;

            foreach (var item in Users)
            {
                if (item.Equal(ref user1))
                {
                    user2 = item;
                }
            }

            if (user2 is null)
            {
                Console.WriteLine("Belə İstifadəçi Yoxdu.");
                Thread.Sleep(1100);
            }
            else
            {
                Console.WriteLine("Uğurla geydiyatdan keçdiniz.");
                Thread.Sleep(1100);
                User = user2;
                return true;
            }

            return false;
        }

        void Register()
        {
        Start:

            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("\t\t\tRegister");

            Console.Write("Name: ");
            var name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Xaiş olunur düzgün daxil edin.");
                Thread.Sleep(1200);
                goto Start;
            }

            Console.Write("Login: ");
            var login = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(login))
            {
                Console.WriteLine("Xaiş olunur düzgün daxil edin.");
                Thread.Sleep(1200);
                goto Start;
            }

            Console.Write("Password: ");
            var password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Xaiş olunur düzgün daxil edin.");
                Thread.Sleep(1200);
                goto Start;
            }

            var useradd = new User(name, login.ToLower(), password, new List<Product> { });

            Users.Add(useradd);
        }

        void Menyu2()
        {
            int colorChoice = 0;

            ConsoleKeyInfo key;

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("\t\t\tCategories");

                Console.WriteLine("Çıxmaq Üçün Esc Basın.");
                Console.WriteLine("Səbətə Keçmək Üçün Space Basın.");

                for (int i = 0; i < Mehsul.Count; i++)
                {
                    if (i == colorChoice)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Mehsul[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        if (colorChoice > 0)
                            colorChoice--;
                        else colorChoice = Mehsul.Count;
                        break;
                    case ConsoleKey.S:
                        if (colorChoice < Mehsul.Count)
                            colorChoice++;
                        else colorChoice = 0;
                        break;
                    case ConsoleKey.Enter:
                        Menyu3(Mehsul[colorChoice].Products);
                        break;
                    case ConsoleKey.Spacebar:
                        Menyu4();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            }
        }

        void Menyu3(List<Product> product)
        {
            int colorChoice = 0;

            ConsoleKeyInfo key;

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("\t\t\tProducts");

                Console.WriteLine("Çıxmaq Üçün Esc Basın.");

                for (int i = 0; i < product.Count; i++)
                {
                    if (i == colorChoice)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(product[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        if (colorChoice > 0)
                            colorChoice--;
                        else colorChoice = product.Count;
                        break;
                    case ConsoleKey.S:
                        if (colorChoice < product.Count)
                            colorChoice++;
                        else colorChoice = 0;
                        break;
                    case ConsoleKey.Enter:
                        ProductAddBasket(product[colorChoice]);
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            }
        }

        void ProductAddBasket(Product product)
        {
            User.Basket.Add(product);

            Console.WriteLine("Produkt Əlavə Olundu.");

            Thread.Sleep(1100);
        }

        void Menyu4()
        {
            List<Product> products = User.Basket;
            int colorChoice = 0;
            double allPrice = AllProductsPrice.AllPrice(products);
            ConsoleKeyInfo key;
            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("\t\t\tSebet");

                Console.WriteLine("Çıxmaq Üçün Esc Basın.");
                Console.WriteLine("Ödəniş Etmək Üçün Space Basın.");
                Console.WriteLine($"Qiymət: {allPrice}");

                for (int i = 0; i < products.Count; i++)
                {
                    if (i == colorChoice)
                        Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(products[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey();

                switch (key.Key)
                {
                    case ConsoleKey.W:
                        if (colorChoice > 0)
                            colorChoice--;
                        else colorChoice = products.Count;
                        break;
                    case ConsoleKey.S:
                        if (colorChoice < products.Count)
                            colorChoice++;
                        else colorChoice = 0;
                        break;
                    case ConsoleKey.Enter:
                        SebetDelete(products[colorChoice]);
                        break;
                    case ConsoleKey.Spacebar:

                        break;
                    case ConsoleKey.Escape:
                        SebetbBuy(allPrice);
                        return;
                    default:
                        break;
                }
            }
        }

        void SebetDelete(Product product)
        {
            User.Basket.Remove(product);
            Console.WriteLine("Element Silindi.");
            Thread.Sleep(1000);
        }

        void SebetbBuy(double price)
        {
        Start:

            Console.Clear();
            Console.ResetColor();

            Console.WriteLine($"Sizin {price} ödəməlisiniz.");

            Console.Write("Məbləğ: ");
            var price_str = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(price_str))
            {
                Console.WriteLine("Xaiş olunur düzgün daxil edin.");
                Thread.Sleep(1200);
                goto Start;
            }

            if (!(double.TryParse(price_str, out double price1)))
            {
                Console.WriteLine("Xaiş olunur düzgün daxil edin.");
                Thread.Sleep(1200);
                goto Start;
            }

            if (price1 < price)
            {
                Console.WriteLine("Daxil Etdiyiniz Məbləğ Azdır.");
                Thread.Sleep(1200);
                goto Start;
            }

            if (price1 > price)
            {
                Console.WriteLine($"Qalığ {price1 - price}");
                Thread.Sleep(1000);
                User.Basket.Clear();
            }
            else if (price1 == price)
            {
                Console.WriteLine("Ödənildi.");
                Thread.Sleep(1000);
                User.Basket.Clear();
            }
        }

        public void Start()
        {
            while (true)
            {
                Menyu1();
                Menyu2();
            }
        }
    }
}

