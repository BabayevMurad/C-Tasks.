using System.ComponentModel.Design;
using System.Globalization;
using System.Text;

namespace Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            const byte size = 10;

            uint xal = 0;

            string[] suallar = new string[size]{
                "Bakı Şəhərinin Paytaxtı: ",
                "Python Hansı Prinsiple Build Olur: ",
                "Aşağdakılardan Hansı Ən Axrıncı Hansı Din Yaranıb: ",
                "Ən Dərin Metro Stansiyası Hansı Ölkədə Yerləşir: ",
                "AXC Haçan Yaranıb: ",
                "Abş-nin 46-cı Prezidenti: ",
                "Şuçanın İşğaldan Azad Olunan Tarix: ",
                "Bakı Metropolitenin Açılışı Haçan Baş Vermişdir: ",
                "Bakıda Tramvay Haçan İşinə Başlayıb: ",
                "Şah İsmayıl Xətainin Doğum Tarixi: "
            };

            string[][] cavalar = new string[size][];
            cavalar[0] = new[] { "Bakı", "Səki", "Naxçıvan" };
            cavalar[1] = new[] { "Jit", "Compiler", "Intrepritator" };
            cavalar[2] = new[] { "İslam", "Yahudi", "Xristian" };
            cavalar[3] = new[] { "Rusiya", "Ukrayna", "Azərbaycan" };
            cavalar[4] = new[] { "1991", "1918", "1923" };
            cavalar[5] = new[] { "Joe Biden", "Donald Trump", "Barack Obama" };
            cavalar[6] = new[] { "8 Noyabr", "6 Oktyabr", "15 İyun" };
            cavalar[7] = new[] { "19 Avqust 1976", "6 Noyabr 1967", "14 May 1971" };
            cavalar[8] = new[] { "1919", "1956", "1904" };
            cavalar[9] = new[] { "1487", "1592", "1348" };

            string[] duzguncavablar = {
                "Bakı",
                "Intrepritator",
                "İslam",
                "Ukrayna",
                "1918",
                "Joe Biden",
                "8 Noyabr",
                "6 Noyabr 1967",
                "1904",
                "1487"
            };

            string[] variantlar = { "A", "B", "C" };

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Xal: {xal}");

                Console.WriteLine(suallar[i]);

                Random random = new Random();

                random.Shuffle(cavalar[i]);



                for (int j = 0; j < 3; j++)
                {

                    Console.WriteLine($"{variantlar[j]}: {cavalar[i][j]}");

                }

                Console.Write("Variantı Daxil edin: ");


                string cavab = Console.ReadLine().ToUpper();

                Console.Clear();

                int index = -1;

                string duzgunvariant = string.Empty;

                if (cavab == "A" || cavab == "B" || cavab == "C")
                {

                    for (int j = 0; j < 3; j++)
                    {
                        if (duzguncavablar[i] == cavalar[i][j])
                        {
                            index = j + 1;
                            break;
                        }
                    }

                    if (index == 1)
                    {
                        duzgunvariant = "A";
                    }
                    else if (index == 2)
                    {
                        duzgunvariant = "B";
                    }
                    else if (index == 3)
                    {
                        duzgunvariant = "C";
                    }

                    if (duzgunvariant == cavab)
                    {
                        Console.WriteLine(suallar[i]);
                        for (int j = 0; j < 3; j++)
                        {
                            if (j == index - 1)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.WriteLine($"{variantlar[j]}: {cavalar[i][j]}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine($"{variantlar[j]}: {cavalar[i][j]}");
                            }
                        }
                        xal += 10;
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        int cavab_index = -1;
                        if (cavab == "A")
                        {
                            cavab_index = 0;
                        }
                        else if (cavab == "B")
                        {
                            cavab_index = 1;
                        }
                        else if (cavab == "C")
                        {
                            cavab_index = 2;
                        }
                        Console.WriteLine(suallar[i]);
                        for (int j = 0; j < 3; j++)
                        {
                            if (j == cavab_index)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{variantlar[j]}: {cavalar[i][j]}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine($"{variantlar[j]}: {cavalar[i][j]}");
                            }
                        }
                        if (!(xal == 0))
                        {
                            xal -= 10;
                        }
                        Thread.Sleep(2000);
                        Console.Clear();
                    }

                }

            }

            Console.WriteLine($"Sizin Xalınız: {xal}");
            Console.Write($"Çıxmaq Üçün İstənilən Knopkaya Basın: ");
            Console.ReadKey();

        }
    }
}