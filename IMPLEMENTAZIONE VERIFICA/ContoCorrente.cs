using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMPLEMENTAZIONE_VERIFICA
{
    class ContoCorrente
    {
        private string id;
        private string cliente;
        private string banca;
        private float saldo;

        private void setId(string id)
        {
            this.id = id;
        }
        private void setCliente(string cliente)
        {
            this.cliente = cliente;
        }
        private void setBanca(string banca)
        {
            this.banca = banca;
        }
        private void setSaldo(float saldo)
        {
            this.saldo = saldo;
        }

        public ContoCorrente(string id, string cliente, string banca, float saldo)
        {
            setId(id);
            setBanca(banca);
            setCliente(cliente);
            setSaldo(saldo);
        }

        public float getSaldo()
        {
            return saldo;
        }

        public void Deposita(float somma)
        {
            //se la somma che si vuole depositare è negativa non si potrà svolgere il deposito
            if (somma <= 0)
            {
                throw new Exception("La somma deve essere un numero positivo");     
            }
            else 
            {
                setSaldo(getSaldo() + somma);
            }
        }

        public void Preleva(float prelievo)
        {
            if (prelievo <= 0)
            {
                throw new Exception("La somma deve essere un numero positivo");
            }
            else if (getSaldo() < prelievo)
            {
                throw new Exception("La somma non può essere maggiore del saldo corrente");
                
            }
            else
            {
                setSaldo(getSaldo() - prelievo);
            }
        }

        public void Sposta(ContoCorrente destinazione, float somma)
        {

            Preleva(somma);
            //scegliere la destinazione (in questo caso conto1/conto2) in cui verrano spostati i soldi
            destinazione.Deposita(somma);
        }
    }
}
