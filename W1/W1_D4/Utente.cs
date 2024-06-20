using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_D4
{
    internal class Utente
    {
        public static string Username { get; private set; }
        public static DateTime? DataLogin { get; private set; }
        private static bool IsAuthenticated = false;
        private static List<string> ListaAccessi = new List<string>();

        public static void Login(string username, string password, string confermaPassword)
        {
            if (!string.IsNullOrEmpty(username) && password == confermaPassword)
            {
                Username = username;
                DataLogin = DateTime.Now;
                IsAuthenticated = true;
                ListaAccessi.Add($"{DateTime.Now}: Login effettuato da {username}");
                Console.WriteLine("Login effettuato con successo.");
            }
            else
            {
                Console.WriteLine("Username o password non validi. Riprova.");
            }
        }

        public static void Logout()
        {
            if (IsAuthenticated)
            {
                Console.WriteLine($"Logout effettuato dall'utente {Username}.");
                Username = null;
                DataLogin = null;
                IsAuthenticated = false;
            }
            else
            {
                Console.WriteLine("Nessun utente loggato.");
            }
        }

        public static void VerificaLogin()
        {
            if (IsAuthenticated && DataLogin.HasValue)
            {
                Console.WriteLine($"L'utente {Username} ha effettuato il login il {DataLogin.Value}.");
            }
            else
            {
                Console.WriteLine("Nessun utente loggato.");
            }
        }

        public static void ListaDegliAccessi()
        {
            if (ListaAccessi.Count > 0)
            {
                Console.WriteLine("Storico accessi:");
                foreach (var accesso in ListaAccessi)
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("Nessun accesso registrato.");
            }
        }



    }

}
