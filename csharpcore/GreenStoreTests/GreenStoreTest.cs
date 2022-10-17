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
