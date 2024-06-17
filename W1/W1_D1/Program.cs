namespace W1_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta a= new Atleta();
            a.Nome = "Edoardo";
            a.Cognome = "Margiarotti";
            a.Sport = "Scherma";
            a.Descriviti();

            Atleta b= new Atleta();
            b.Nome = "Yury";
            b.Cognome = "Chehi";
            b.Sport = "Ginnastica";
            b.Descriviti();

            Dipendente c= new Dipendente();
            c.Nome = "Paola";
            c.Cognome = "Premoli";
            c.Ruolo = "Capoturno";
            c.Qualifica = "Operaia";
            c.Descriviti();

            Dipendente d= new Dipendente();
            d.Nome = "Elga";
            d.Cognome = "Vedovelli";
            d.Ruolo = "Addetta alle macchine";
            d.Qualifica = "Operaia";
            d.Descriviti();

            Animale e= new Animale();
            e.Nome = "Spy";
            e.Specie = "Felino";
            e.Razza = "Gatto";
            e.Descriviti();

            Animale f = new Animale();
            f.Nome = "Becks";
            f.Specie = "Roditore";
            f.Razza = "Criceto";
            f.Descriviti();

            Veicolo g= new Veicolo();
            g.Proprietario = "Nicola";
            g.Targa = "ab123cd";
            g.Marca = "Seat";
            g.Modello = "Leon";
            g.Descriviti();

            Veicolo h = new Veicolo();
            h.Proprietario = "Stefania";
            h.Targa = "bc234de";
            h.Marca = "Renault";
            h.Modello = "Clio";
            h.Descriviti();
        }
    }
}
