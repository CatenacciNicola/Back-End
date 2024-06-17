using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_D1
{
    internal class Animale
    {
        string nome;
        string specie;
        string razza;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Specie
        {
            get { return specie; }
            set { specie = value; }
        }
        public string Razza
        {
            get { return razza; }
            set { razza = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("Nuovo animale");
            Console.WriteLine(nome);
            Console.WriteLine(specie);
            Console.WriteLine(razza);
        }
    }
}
