// See https://aka.ms/new-console-template for more information
using InventarioApp.Entities;
using System.Text;

Console.WriteLine("Hello, World!");

Console.OutputEncoding = Encoding.UTF8;

/*
 * Creare un programma per la gestione di un magazzino:
– Definire le classi:
    • Prodotto (Id, Nome)
    • Ordine (Id, Data, Dettagli)
    • DettaglioOrdine (Id, Quantità, Prezzo, Prodotto)
    • OrdineDTO (IdOrdine, Data, rappresentante gli ordini evasi)
– Popolare alcune liste con questi elementi
– Definire utilizzando LINQ e le lambda espression una serie di filtri per:
    • Cercare un Ordine per ID e mostrarlo a video
    • Cercare tutti gli ordini in cui la data è all'interno di un certo intervallo di tempo 
        e contenenti un Prodotto specifico e riportare a video gli ID corrispondenti
    • Cercare tutti gli Ordini con quantità totale dei prodotti superiore a 50 e riportare 
        a video gli ID corrispondenti
    • Mostrare a video tutti gli Id degli ordini
    • Mostrare a video tutti gli Ordini che sono stati evasi (join tra lista ordini e lista ordini DTO)
    • Mostrare a video un rapido riepilogo di ogni ordine (ID, Data, Quantità totale, Prezzo totale)
    • Ordinare tutti gli ordini per data e mostrare a video ID e Data di ogni ordine
    • Raggruppare tutti gli ordini per data e mostrare a video quanti ordini ci sono per ogni data
 */

Random rand = new Random();

List<Product> products = new List<Product>()
{
    new Product(name: "Mela"),
    new Product(name: "Pera"),
    new Product(name: "Banana"),
    new Product(name: "Kiwi"),
    new Product(name: "Anguria"),
    new Product(name: "Cioccolato"),
    new Product(name: "Latte"),
    new Product(name: "Pane"),
    new Product(name: "Pollo")
};
List<Order> orders = new List<Order>();

for(int i = 0; i < rand.Next(5,15); i++)
{
    Order o = new Order(new List<Detail>(), new DateTime(2022, rand.Next(1, 13), rand.Next(1, 29)));
    for(int j = 0; j < rand.Next(1, 9); j++)
    {
        Detail d = new Detail(rand.Next(1, 30), rand.Next(10, 50), products[rand.Next(9)]);
        o.Details.Add(d);
    }
    orders.Add(o);
}

orders.ForEach(o =>
{
    Console.WriteLine(o.ToString());
    o.Details.ForEach(d =>  Console.WriteLine(d.ToString()));
});


//List<Order> orders = new List<Order>()
//{
//    new Order(new List<Detail>()
//    {
//        new Detail(quantity: 5, price: 30,product: products[5]),
//        new Detail(quantity: 1, price: 40,product: products[4]),
//        new Detail(quantity: 6, price: 10,product: products[3]),
//        new Detail(quantity: 2, price: 20,product: products[2])
//    }, new DateTime(year: 2010,month: 10,day: 10)),
//    new Order(new List<Detail>()
//    {
//        new Detail(quantity: 5, price: 30,product: products[5]),
//        new Detail(quantity: 1, price: 40,product: products[4]),
//        new Detail(quantity: 6, price: 10,product: products[3]),
//        new Detail(quantity: 2, price: 20,product: products[2])
//    }, new DateTime(year: 2010,month: 10,day: 10))
//};

