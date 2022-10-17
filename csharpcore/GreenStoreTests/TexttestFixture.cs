
using GreenStore.Models;
using System;
using System.Collections.Generic;
using GreenStore;

namespace GreenStoreTests
{
    public static class TexttestFixture
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var items = GetItems();
            var app = new QualityUpdater(items);
            var days = GetDays(args);

            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < items.Count; j++)
                {
                    System.Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }
                Console.WriteLine("");
                app.DoUpdate();
            }
        }

        private static int GetDays(string[] args)
        {
            if (args.Length > 0)
            {
                return int.Parse(args[0]) + 1;
            }
            return 30;
        }

        private static IList<Item> GetItems()
        {
            return new List<Item>
            {
                new Plus3AgilityVestItem { SellIn = 10, Quality = 20 },
                new AgedCheddarItem { SellIn = 2, Quality = 0 },
                new ElixiroftheBearItem { SellIn = 5, Quality = 7 },
                new LongClawItem { SellIn = 0, Quality = 80 },
                new LongClawItem { SellIn = -1, Quality = 80 },
                new ViPTicketsToASamuraiConcertItem { SellIn = 15, Quality = 20 },
                new ViPTicketsToASamuraiConcertItem { SellIn = 10, Quality = 49 },
                new ViPTicketsToASamuraiConcertItem { SellIn = 5, Quality = 49 },
                // this conjured item does not work properly yet
                new ConjuredCharismaPotionItem { SellIn = 3, Quality = 6 }
            };
        }
    }
}
