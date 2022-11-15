using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMPLEMENTAZIONE_VERIFICA
{
    class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto1 = new ContoCorrente("a123", "Tomas", "Ubi", 0);
            ContoCorrente conto2 = new ContoCorrente("b456", "Paolo", "UniCredit", 0);
            //try e catch in caso avessimo delle eccezioni registrate dal throw
            try
            {
                conto1.Deposita(100);
                conto1.Preleva(50);
                Console.WriteLine(conto1.getSaldo());

                conto2.Deposita(1000);
                conto2.Preleva(2000);
                Console.WriteLine(conto2.getSaldo());

                conto1.Sposta(conto2, 50);
            }
            //con exception intendiamo l'exception specificata nella classe ed "e" è il messaggio
            catch(Exception e)
            {
                Console.WriteLine(e);

            }

            Bancomat carta1 = new Bancomat("qwe098", "Ni7G", conto1);
            Bancomat carta2 = new Bancomat("poi345", "3Ghe", conto2);
            try
            {
                carta1.Depositare(40, "Ni7G");
                carta1.Prelevare(50, "3Ghe");
            }
            catch(Exception a)
            {
                Console.WriteLine(a);
            }

            Sportello sportello = new Sportello("851334991", "non so che nome mettere", "Banca Popolare di Sondrio", true);
        }

        
    }
}
