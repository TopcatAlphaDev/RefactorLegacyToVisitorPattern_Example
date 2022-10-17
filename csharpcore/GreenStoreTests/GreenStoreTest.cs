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
            IList<Item> Items = new List<Item> { new Item { Name = "+3 Agility Vest", SellIn = sellIn, Quality = 20 } };
            GreenStore app = new GreenStore(Items);
            app.UpdateQuality();
            Assert.Equal("+3 Agility Vest", Items[0].Name);
            Assert.Equal(expectedQuality, Items[0].Quality);
        }
    }
}
