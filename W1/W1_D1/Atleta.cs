using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_D1
{
    internal class Atleta
    {
        string nome;
        string cognome;
        string sport;
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
        public string Sport
        {
            get { return sport; }
            set { sport = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("Nuovo atleta");
            Console.WriteLine(nome);
            Console.WriteLine(cognome);
            Console.WriteLine(sport);
        }
    }
}
