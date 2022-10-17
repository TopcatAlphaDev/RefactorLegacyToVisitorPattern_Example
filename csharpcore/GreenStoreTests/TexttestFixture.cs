using GreenStore.Models;
using System;
using System.Collections.Generic;
using GreenStore;
using GreenStore.Models.Interfaces;
using GreenStoreTests.Repositories;

namespace GreenStoreTests
{
    public static class TexttestFixture
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var items = new ItemRepository().GetAll();
            var qualityUpdater = new QualityUpdater(items);

            for (var i = 0; i < GetDays(args); i++)
            {
                UpdateUI(i, items);
                qualityUpdater.DoUpdate();
            }
        }

        private static void UpdateUI(int i, IList<IItem> items)
        {
            Console.WriteLine($"-------- day {i} --------");
            Console.WriteLine("name, sellIn, quality");
            foreach (var item in items)
            {
                Console.WriteLine($"{(item as Item)?.Name}, {(item as Item)?.SellIn}, {(item as Item)?.Quality}");
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
    }
}
