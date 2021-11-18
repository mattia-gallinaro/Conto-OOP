using System;

namespace ContaSoldi
{
    class Banca
    {
        public double Conto { get; set; }
        public void Versa(double soldi)
        {
            Conto += soldi;
        }
        public void Preleva(double soldi)
        {
            Conto -= soldi;
        }

        public void SetConto(double soldi)
        {
            Conto = soldi;
        }
        public double StampaConto()
        {
            return Conto;
        }
    }
    class ContoCorrente : Banca
    {
        
        public bool Preleva(string risposta)
        {
            
            try
            {
                double soldi = double.Parse(risposta);
                if (soldi < 0 || soldi > 3000 || (Conto - soldi) < 0)
                {
                    Console.WriteLine("Prelievo non riuscito");
                    return false;
                }
                else
                {
                    base.Preleva(soldi);
                    return true;

                }
            }
            catch
            {
                return false;
            }
        }
        public bool Versa(string risposta)
        {
            try
            {
                double soldi = double.Parse(risposta);
                if (soldi < 0 || soldi > 3000)
                {
                    Console.WriteLine("Versamento non riuscito");
                    return false;
                }
                else
                {
                    Versa(soldi);
                    return true;
                }
            }
            catch
            {
                return false;
            }
              
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            double scelta;
            ContoCorrente c = new ContoCorrente();
            Console.WriteLine("Inserisci il tuo conto corrente");
            scelta = double.Parse(Console.ReadLine());
            c.SetConto(scelta);
            string risposta;
            Console.WriteLine("Inserisci la quantità di soldi da versare");
            risposta = Console.ReadLine();
            while (!c.Versa(risposta))
            {
                Console.WriteLine("Inserisci la quantità di soldi da versare");
                risposta = Console.ReadLine();
            }
            Console.WriteLine("Inserisci la quantità di soldi da prelevare");
            risposta = Console.ReadLine();
            while (!c.Preleva(risposta))
            {
                Console.WriteLine("Inserisci la quantità di soldi da prelevare");
                risposta = Console.ReadLine();
            }
            Console.WriteLine("Il tuo saldo e': {0}", Convert.ToString(c.StampaConto()));
        }
    }
}
