using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPLEMENTAZIONE_VERIFICA
{
    class Sportello
    {
        private string _id;
        private string _indirizzo;
        private string _banca;
        private bool _disponibilità;
        private Bancomat seriale;
        string[] blokkata = new string[100];
    
        public Sportello(string id, string indirizzo, string banca, bool disponibiltà)
        {
            Id = id;
            Indirizzo = indirizzo;
            Banca = banca;
            setStato(_disponibilità);
        }
        public string Id;
        public string Indirizzo;
        public string Banca;

        public bool getStato()
        {
            return _disponibilità;
        }
        private void setStato(bool stato)
        {
            this._disponibilità = stato;
        }

        public void Inserisci (Bancomat carta, bool disponibilità)
        {
            bool check=false;
            
            for (int i=0; i != 100; i++) 
            {
                if (seriale.getId() == blokkata[i])
                {
                    Console.WriteLine("Carta Bloccata");
                    setStato(true);
                    check = true;
                } 
            }
            if (check == false)
            {
                setStato(false);
            }
        }
        public void Rimuovi(Bancomat carta, bool disponibilità)
        {
            setStato(true);
        }
    }
}
