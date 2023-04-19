using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_composizione
{
    public class Negozio
    {
        //Lo shop deve avere un nome, una citta, un indirizzo, un numero civico
        private string nome;
        private string città;
        private string indirizzo;
        private int numeroCivico;

        private List<Prodotto> prodotti;

        public void Shop(string nome, string città, string indirizzo, int numeroCivico)
        {
            this.nome = nome;
            this.città = città;
            this.indirizzo = indirizzo;
            this.numeroCivico = numeroCivico;

            this.prodotti = new List<Prodotto>();
        }

        //si possano chiedere ognuna delle informazioni contenute nel negozio

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCittà()
        {
            return this.città;
        }

        public string GetIndirizzo()
        {
            return this.indirizzo;
        }

        public int GetNumeroCivico()
        {
            return this.numeroCivico;
        }

        public List<Prodotto> GetProdotti()
        {
            return this.prodotti;
        }

        //si possa modificare alcune delle informazioni dello shop

    }
}