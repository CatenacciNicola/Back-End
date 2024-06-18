using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_D2
{
    internal class Persona
    {
        string nome;
        string cognome;
        int eta;
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
        public int Eta
        {
            get { return eta; }
            set { eta = value; }
        }
        public void GetNome()
        {
            Console.WriteLine(nome);
        }
        public void GetCognome()
        {
            Console.WriteLine(cognome);
        }
        public void GetEta()
        {
            Console.WriteLine(eta);
        }
        public void GetDettagli()
        {
            Console.Write("Mi chiamo ");
            Console.Write(nome);
            Console.Write(cognome);
            Console.Write(" e ho ");
            Console.Write(eta);
            Console.Write("anni");

        }
    }
}
