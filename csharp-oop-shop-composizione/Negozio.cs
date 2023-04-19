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
        private string citta;
        private string indirizzo;
        private int numeroCivico;

        private List<Prodotto> prodotti;

        public void Shop(string nome, string citta, string indirizzo, int numeroCivico)
        {
            this.nome = nome;
            this.citta = citta;
            this.indirizzo = indirizzo;
            this.numeroCivico = numeroCivico;

            this.prodotti = new List<Prodotto>();
        }

        //si possano chiedere ognuna delle informazioni contenute nel negozio

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCitta()
        {
            return this.citta;
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

        public void CambiaCitta(string citta)
        {
            this.citta = citta;
        }

        public void CambiaIndirizzo(string indirizzo)
        {
            this.indirizzo = indirizzo;
        }

        public void CambiaNumeroCivico(int numeroCivico)
        {
            this.numeroCivico = numeroCivico;
        }

        //si possa inserire la lista di prodotti inziali o eventualmente una lista di prodotti nuovi che tratterò in più da oggi in poi nel negozio.
 
        public void aggiungiListaProdotti(List<Prodotto> ProdottiDaAggiungere)
        {
            foreach (Prodotto ProdottoDaAggiungere in ProdottiDaAggiungere)
            {
                this.prodotti.Add(ProdottoDaAggiungere);
            }
        }
        
        //si possa inserire anche un prodotto singolo in più al negozio
        
        public void aggiungiProdotto(Prodotto nuovoProdotto)
        {
            prodotti.Add(nuovoProdotto);
        }

        //si possa chiedere ad uno shop di darmi la sua rappresentazione in stringa e io possa stamparla in Console.

        public string RappStringa()
        {
            string rapprStringa = "Nome: " + this.nome + "\n";
            rapprStringa += "Città: " + this.citta + "\n";
            rapprStringa += "Indirizzo: " + this.indirizzo + "\n";
            rapprStringa += "Numero Civico: " + this.numeroCivico + "\n";
            rapprStringa += "Prodotti: \n";

            return rapprStringa;
        }

    }

}