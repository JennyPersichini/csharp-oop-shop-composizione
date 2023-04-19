// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using csharp_oop_shop_composizione;

Negozio negozioCarrefour = new Negozio("Carrefour", "Roma", "Via VattelaAPesca", 120);

Prodotto prodottoArance = new Prodotto("Arance", "Un Sacchetto da un kilo di Arance siciliane", 15, 10);
Prodotto prodottoPane = new Prodotto("Pane", "Pane integrale dal banco", 2, 5);

/*List<Prodotto> prodottiCarrefour = new List<Prodotto> { prodottoArance, prodottoPane };

negozioCarrefour.aggiungiProdotto(prodottiCarrefour);

Console.WriteLine(negozioCarrefour.RappStringa());
*/

negozioCarrefour.aggiungiProdotto(prodottoArance);
negozioCarrefour.aggiungiProdotto(prodottoPane);

Console.WriteLine(negozioCarrefour.RappStringa());
