using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1_D1
{
    internal class Veicolo
    {
        string proprietario;
        string targa;
        string marca;
        string modello;
        public string Proprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }
        public string Targa
        {
            get { return targa; }
            set { targa = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modello
        {
            get { return modello; }
            set { modello = value; }
        }
        public void Descriviti()
        {
            Console.WriteLine("Nuovo veicolo");
            Console.WriteLine(proprietario);
            Console.WriteLine(targa);
            Console.WriteLine(marca);
            Console.WriteLine(modello);
        }
    }
}
