using System;
using System.Collections.Generic;
namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        { 
        Dictionary<string, string> stocks = new Dictionary<string, string>();
        stocks.Add("GM", "General Motors");
        stocks.Add("CAT", "Caterpillar");
        stocks.Add("XBX", "Xbox");
        stocks.Add("CKN", "Chicken");

        List<(string ticker, int shares, double price)> purchases = new List<(string ticker, int shares, double price)>()
        {
            ("GM", 25, 300.54),
            ("GM", 30, 350.63),
            ("CAT", 342, 1035.63),
            ("CAT", 32, 50.63),
            ("XBX", 40, 850.63),
            ("XBX", 45, 1050.63),
            ("CKN", 33, 150.63),
            ("CKN", 50, 257.63),
        };
        Dictionary<string, double> portfolio = new Dictionary<string, double>();
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                string fullCompanyName = stocks[purchase.ticker];
                // Does the company name key already exist in the report dictionary?
                if (portfolio.ContainsKey(fullCompanyName)) {
                    // If it does, update the total valuation
                    portfolio[fullCompanyName] += purchase.shares * purchase.price;
                } else {
                    // If not, add the new key and set its value
                    portfolio[fullCompanyName] = purchase.shares * purchase.price;
                }
            }

            foreach (KeyValuePair<string, double> stock in portfolio)
            {
                Console.WriteLine($"I own {stock.Key} stock for a total cost of {stock.Value.ToString("C")}");
            }
        }
    }
}
