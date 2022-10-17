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
            var qualityUpdater = new QualityUpdater(items);

            for (var i = 0; i < GetDays(args); i++)
            {
                UpdateUI(i, items);
                qualityUpdater.DoUpdate();
            }
        }

        private static void UpdateUI(int i, IList<Item> items)
        {
            Console.WriteLine($"-------- day {i} --------");
            Console.WriteLine("name, sellIn, quality");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name}, {item.SellIn}, {item.Quality}");
            }
            Console.WriteLine("");
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
