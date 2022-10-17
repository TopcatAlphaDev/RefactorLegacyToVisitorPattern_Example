using Xunit;
using System.Collections.Generic;
using GreenStoreKata;

namespace GreenStoreTests
{
    public class GreenStoreTest
    {

        [Theory]
        [InlineData(-1, 18)]
        [InlineData(0, 18)]
        [InlineData(5, 19)]
        [InlineData(10, 19)]
        [InlineData(100, 19)]
        public void plus3_Agility_Vest_decreasing_quality(int sellIn, int expectedQuality)
        {
            var itemquality = 20;
            var itemName = "+3 Agility Vest";
            TestItemQuality(sellIn, expectedQuality, itemquality, itemName);
        }

        [Theory]
        [InlineData(-1, 2)]
        [InlineData(0, 2)]
        [InlineData(5, 1)]
        [InlineData(10, 1)]
        [InlineData(100, 1)]
        public void Aged_Cheddar_increasing_quality(int sellIn, int expectedQuality)
        {
            var itemquality = 0;
            var itemName = "Aged Cheddar";
            TestItemQuality(sellIn, expectedQuality, itemquality, itemName);
        }

        [Theory]
        [InlineData(-1, 80)]
        [InlineData(0, 80)]
        [InlineData(5, 80)]
        [InlineData(9, 80)]
        [InlineData(10, 80)]
        [InlineData(100, 80)]
        public void Longclaw_fixed_quality(int sellIn, int expectedQuality)
        {
            var itemquality = 80;
            var itemName = "Longclaw";
            TestItemQuality(sellIn, expectedQuality, itemquality, itemName);
        }

        [Theory]
        [InlineData(-1, 5)]
        [InlineData(0, 5)]
        [InlineData(5, 6)]
        [InlineData(9, 6)]
        [InlineData(10, 6)]
        [InlineData(100, 6)]
        public void Elixir_of_the_Bear_quality(int sellIn, int expectedQuality)
        {
            var itemquality = 7;
            var itemName = "Elixir of the Bear";
            TestItemQuality(sellIn, expectedQuality, itemquality, itemName);
        }

        [Theory]
        [InlineData(-1, 49, 0)]
        [InlineData(0, 49, 0)]
        [InlineData(4, 49, 50)]
        [InlineData(5, 49, 50)]
        [InlineData(6, 49, 50)]
        [InlineData(9, 49, 50)]
        [InlineData(10, 49, 50)]
        [InlineData(11, 49, 50)]
        [InlineData(100, 49, 50)]

        [InlineData(-1, 20, 0)]
        [InlineData(0, 20, 0)]
        [InlineData(14, 20, 21)]
        [InlineData(15, 20, 21)]
        [InlineData(16, 20, 21)]
        [InlineData(100, 20, 21)]
        public void VIP_tickets_to_a_Samurai_concert_quality(int sellIn, int itemQuality, int expectedQuality)
        {
            var itemName = "VIP tickets to a Samurai concert";
            TestItemQuality(sellIn, expectedQuality, itemQuality, itemName);
        }

        [Theory]
        [InlineData(-1, 4)]
        [InlineData(0, 4)]
        [InlineData(3, 5)]
        [InlineData(5, 5)]
        [InlineData(9, 5)]
        [InlineData(10, 5)]
        [InlineData(100, 5)]
        public void Conjured_Charisma_Potion_quality(int sellIn, int expectedQuality)
        {
            var itemquality = 6;
            var itemName = "Conjured Charisma Potion";
            TestItemQuality(sellIn, expectedQuality, itemquality, itemName);
        }

        private static void TestItemQuality(int sellIn, int expectedQuality, int itemquality, string itemName)
        {
            IList<Item> Items = new List<Item> { new Item { Name = itemName, SellIn = sellIn, Quality = itemquality } };
            GreenStore app = new GreenStore(Items);
            app.UpdateQuality();
            Assert.Equal(itemName, Items[0].Name);
            Assert.Equal(expectedQuality, Items[0].Quality);
        }


    }
}
