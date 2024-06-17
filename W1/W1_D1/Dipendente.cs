using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_D1
{
    internal class Dipendente
    {
        string nome;
        string cognome;
        string ruolo;
        string qualifica;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }
        public string Ruolo
        {
            get { return ruolo; }
            set { ruolo = value; }
        }
        public string Qualifica
        {
            get { return qualifica; }
            set { qualifica = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("Nuovo dipendente");
            Console.WriteLine(nome);
            Console.WriteLine(cognome);
            Console.WriteLine(ruolo);
            Console.WriteLine(qualifica);
        }
    }
}
