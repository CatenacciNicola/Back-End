﻿namespace W1_D4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Write("Inserisci username: ");
                        string username = Console.ReadLine();
                        Console.Write("Inserisci password: ");
                        string password = Console.ReadLine();
                        Console.Write("Conferma password: ");
                        string confermaPassword = Console.ReadLine();
                        Utente.Login(username, password, confermaPassword);
                        break;
                    case "2":
                        Utente.Logout();
                        break;
                    case "3":
                        Utente.VerificaLogin();
                        break;
                    case "4":
                        Utente.ListaDegliAccessi();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }

            }
        }
    }
}
