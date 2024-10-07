using System;


namespace Televisore
{
    public class Televisore
    {
        public string Marca;
        public string Modello;
        public int Dimensione;
        public bool Stato;
        public int Canale_Attuale;
        public int Volume_Attuale;

        public Televisore(string marca, string modello, int dimensione)
        {
            Marca = marca;
            Modello = modello;
            Dimensione = dimensione;
            Stato = false;
            Canale_Attuale = 1;
            Volume_Attuale = 0;
        }

        public void Accendi()
        {
            Stato = true;
            Console.WriteLine("televisore: acceso.");
        }

        public void Spegni()
        {
            Stato = false;
            Console.WriteLine("televisore: spento.");
        }

        public void Cambia_Canale(int nuovoCanale)
        {
            if (Stato)
            {
                Canale_Attuale = nuovoCanale;
                Console.WriteLine("canale cambiato a " + Canale_Attuale);
            }
            else
            {
                Console.WriteLine("il televisore è spento.");
            }
        }

        public void Cambia_Volume(int nuovoVolume)
        {
            if (Stato)
            {
                Volume_Attuale = nuovoVolume;
                Console.WriteLine("volume cambiato a " + Volume_Attuale);
            }
            else
            {
                Console.WriteLine("il televisore è spento.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Televisore s1 = new Televisore("Marca1", "Modello1", 100);
            Televisore s2 = new Televisore("Marca2", "Modello2", 120);

            Console.WriteLine("Schermo 1:");

            s1.Accendi();
            s1.Cambia_Canale(5);
            s1.Cambia_Volume(3);

            Console.WriteLine("Schermo 2:");

            s2.Accendi();
            s2.Cambia_Canale(10);
            s2.Cambia_Volume(10);

        }
    }
}