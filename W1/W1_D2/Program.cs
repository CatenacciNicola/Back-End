namespace W1_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nome = "Nicola";
            persona.Cognome = "Catenacci";
            persona.Eta = 29;
            persona.GetDettagli();
        }
    }
}
