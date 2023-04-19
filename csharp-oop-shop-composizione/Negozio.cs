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
    }

}