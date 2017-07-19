using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("F", "Ford");
            stocks.Add("GE", "General Electric");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "F", shares: 34, price: 19.87));
            purchases.Add((ticker: "F", shares: 48, price: 20.7));
            purchases.Add((ticker: "AAPL", shares: 34, price: 190.87));
            purchases.Add((ticker: "AAPL", shares: 23, price: 200.59));
            purchases.Add((ticker: "CAT", shares: 14, price: 90.87));
            purchases.Add((ticker: "CAT", shares: 94, price: 85.43));
            purchases.Add((ticker: "GM", shares: 74, price: 20.87));
            purchases.Add((ticker: "GM", shares: 24, price: 15.53));

            Dictionary<string, double> totalOwned = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (stocks.ContainsKey(purchase.ticker))
                {
                    if (totalOwned.ContainsKey(stocks[purchase.ticker]))
                    {
                        totalOwned[stocks[purchase.ticker]] += purchase.price * purchase.shares;
                    }else
                    {
                        totalOwned.Add(stocks[purchase.ticker], purchase.price * purchase.shares);
                    }
                }
            }

            foreach (KeyValuePair<string, double> total in totalOwned)
            {
                Console.WriteLine(total);
            }
            Console.Read();
        }
    }
}
