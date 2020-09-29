using System;
using Microsoft.VisualBasic.CompilerServices;

namespace GimpiesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultTitle = "Gimpies Voorraad systeem | Developed by: Kwasidk";
            Console.Title = defaultTitle ;
            
            string[] userCredential = {"Beheerder", "Intern", "Inkoop"};
            string[] passwordCredential = {"Beheerder01", "Intern01", "Inkoop01"};
            
            int loginCounter = 3;

            bool hasAccess;
            
            
            Console.WriteLine(defaultTitle);
            Console.WriteLine(" ");

            while (true)
            {
                Console.WriteLine("Voer uw gebruikersnaam in: ");

                string userLogin = Console.ReadLine();

                Console.WriteLine("Voer uw wachtwoord in:");

                string userPassword = GetPassword();

                if (userLogin == userCredential[2]  && userPassword == passwordCredential[2])
                {
                    EnviromentInkoop();
                    hasAccess = true;
                }
                else
                {
                    Console.Clear();
                    loginCounter--;
                    Console.WriteLine("Gegevens kloppen niet, probeer het opnieuw.");
                    Console.WriteLine("U heeft " + loginCounter + " poging(en)!");
                    Console.WriteLine("");
                }

                if (loginCounter == 0)
                {
                    Console.WriteLine("Je hebt 3 pogingen gehad, probeer het later opnieuw!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }

        public static string GetPassword()
        {
            string userPassword = String.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && userPassword.Length > 0)
                {
                    Console.Write("\b \b");
                    userPassword = userPassword[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    userPassword += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            return userPassword;
        }

        public static void EnviromentInkoop()
        {
            Console.Clear();
            
            Console.WriteLine("Ingelogd als Inkoop");
            
            Console.WriteLine("1: Naar schoenen overzicht");
            Console.WriteLine("2: Uitloggen ");

            int keuzeMenu = Convert.ToInt32(Console.ReadLine());
            switch (keuzeMenu)
            {
                case 1:
                    string[] Nike = new string[4]
                    {
                        "1",
                        "Nike",
                        "Air Force 1",
                        "0"
                    };
                    
                    string[] adidas = new string[4]
                    {
                        "2",
                        "Adidas",
                        "Ultraboost",
                        "6"
                    };

                    ShowOverviewShoes(Nike, adidas);
                    break;
                case 2:
                    Console.WriteLine("Fijne dag verder!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    EnviromentInkoop();
                    break;
            }
            
        }

        public static void ShowOverviewShoes(string [] shoe1 , string [] shoe2)
        {
            // Console.WriteLine("Haha prank neef!");
            // Console.ReadKey();


            if (Convert.ToInt32(shoe1[3]) < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            } else if (Convert.ToInt32(shoe2[3]) < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            
            Console.WriteLine("ID: " + shoe1 [0] + " Merk: " + shoe1[1] + " Model: " + shoe1[2] + " Aantallen: " + shoe1[3] );
            Console.WriteLine("");
            Console.WriteLine("ID: " + shoe2 [0] + " Merk: " + shoe2[1] + " Model: " + shoe2[2] + " Aantallen: " + shoe2[3] );
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
