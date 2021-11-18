using System;

namespace ClassiDerivate
{
    // Classe base.
    class Persona
    {
        public int Badge { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }

        public void StampaInformazioni()
        {
            Console.WriteLine("Badge: {0} Cognome: {1} Nome: {2} ", Badge.ToString(), Cognome, Nome);
        }
    }
    // Prima classe derivata.
    // Dipendente deriva da Persona
    // eredita gli attributi ed il metodo da Persona
    class Dipendente : Persona
    {
        public int Matricola { get; set; }
        public int Retribuzione { get; set; }
        new public void StampaInformazioni()
        {
            //Console.WriteLine("Badge: {0} Cognome: {1} Nome: {2} Matricola: {3} Retribuzione: {4}", Badge.ToString(), Cognome, Nome, Matricola, Retribuzione);
            base.StampaInformazioni();
            Console.WriteLine("Matricola: {0} Retribuzione: {1}", Matricola, Retribuzione);
        }
    }

    // Seconda classe derivata.
    // Collaboratore deriva da Persona
    class Collaboratore : Persona
    {
        public string Azienda { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona()
            {
                Badge = 1,
                Cognome = "Da Vinci",
                Nome = "Leonardo"
            };
            Dipendente d = new Dipendente()
            {
                Badge = 2,
                Cognome = "Buonarroti",
                Nome = "Michelangelo",
                Matricola = 1,
                Retribuzione = 100
            };
            Collaboratore c = new Collaboratore()
            {
                Badge = 3,
                Cognome = "Vecellio",
                Nome = "Tiziano",
                Azienda = "Abc"
            };
            p.StampaInformazioni();
            d.StampaInformazioni();
            c.StampaInformazioni();
        }
    }
}
