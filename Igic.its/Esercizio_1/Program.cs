using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFruit> basket = new List<IFruit>();

            //inserisco elementi a caso
            //basket.Add(new Ananas()); 
            //basket.Add(new Ananas());
            //basket.Add(new Apple());
            //basket.Add(new Apple());
            //basket.Add(new Orange());

            Console.WriteLine("[0] Inserisci frutta");
            Console.WriteLine("[1] Stampa carrello\n");
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            switch (keyPressed.KeyChar)
            {
                case '0':
                    Console.WriteLine("[0] Ananas");
                    Console.WriteLine("[1] Arancia");
                    Console.WriteLine("[2] Mela\n");
                    keyPressed = Console.ReadKey();
                    Console.Write("Quanti? ");
                    var q = Convert.ToInt32(Console.ReadLine());
                    switch (keyPressed.KeyChar)
                    {
                        case '0':
                            for (int i = 0; i < q; i++)
                                basket.Add(new Ananas());
                            Main(new String[0]);
                            break;
                        case '1':
                            for (int i = 0; i < q; i++)
                                basket.Add(new Orange());
                            break;
                        case '2':
                            for (int i = 0; i < q; i++)
                                basket.Add(new Apple());
                            break;

                    }
                    break;
                case '1':
                    Dictionary<String, int> checkout = new Dictionary<String, int>();
                    foreach (var item in basket)
                    {
                        if (checkout.ContainsKey(item.GetName()))
                        {
                            checkout[item.GetName()]++;
                        }
                        else
                        {
                            checkout.Add(item.GetName(), 1);
                        }
                    }

                    Console.WriteLine("Ci sono: ");
                    foreach (var item in checkout)
                    {
                        Console.WriteLine($"{item.Value} {item.Key}");
                    }

                    //Console.WriteLine($"Prezzo totale = {basket.GetTotalCost()}");
                    Console.WriteLine($@"\nPrezzo totale = {GetTotalCost(basket)} euro");

                    //frutta presente nella lista. senza ripetizioni
                    List<IFruit> fruttapresente = new List<IFruit>();
                    foreach (var item in basket)
                    {
                        if (!fruttapresente.Contains(item)) // Non funziona perchè quell'oggetto non è presente (vede indirizzi in mem e non contenuto) 
                            fruttapresente.Add(item);
                    }

                    Console.WriteLine("\nPrezzo per tipologia: ");
                    foreach (var item in fruttapresente)
                    {
                        Console.WriteLine($"prezzo {item.GetName()} - {GetRelativeCost(item, basket)}");
                    }
                    break;
            }

            
            Console.ReadKey();
        }

        /// <summary>
        /// Calcola il prezzo degli elementi nel carrello
        /// </summary>
        /// <returns>Ritorna il costo totale della frutta nel carrello</returns>
        public static double GetTotalCost(List<IFruit> basket)
        {
            double totalCost = 0.0;
            foreach (var item in basket)
            {
                totalCost += item.GetPrice();
            }
            return totalCost;
        }

        /// <summary>
        /// Calcola il 
        /// </summary>
        /// <param name="element">what</param>
        /// <param name="reps">how many</param>
        /// <returns></returns>
        private static double GetFruitCost(IFruit element, int reps)
        {
            return element.GetPrice() * reps;
        }

        /// <summary>
        /// Calcola il prezzo totale del frutto specificato della lista
        /// </summary>
        /// <param name="element">cosa</param>
        /// <param name="list">dove</param>
        /// <returns></returns>
        public static double GetRelativeCost(IFruit element, List<IFruit> list)
        {
            int reps = 0; // corrisponde al prezzo del frutto
            if (!list.Contains(element))
                throw new Exception("Elemento non presente nella lista");
            else
            {
                foreach (var item in list)
                {
                    // se l'elemento cercato corrisponde a quello nella lista che guardo 
                    // ora allora incremento reps (= volte che il frutto è presente nella lista)
                    if (item.GetName().Equals(element.GetName()))
                        reps++;
                }
                return GetFruitCost(element, reps);
            }
        }
    }
}
