using System;
using AsilStok;

namespace ST
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Stock elma = new Stock("elma");
            elma.PriceChanced += OnPriceChanged;
            elma.Price = 20.4M;
            elma.Price = 50;
            Console.ReadKey();

        }

        static void OnPriceChanged(object o, PriceChancedEventArgs e)
        {
            Console.WriteLine("eski fiyat:" + e.oldPrice);
            Console.WriteLine("yeni fiyat:" + e.newPrice);
        }
    }
 }
   