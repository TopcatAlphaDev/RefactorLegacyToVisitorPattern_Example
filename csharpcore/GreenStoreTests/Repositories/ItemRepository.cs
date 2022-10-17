using System.Collections.Generic;
using GreenStore.Models;
using GreenStore.Models.Interfaces;

namespace GreenStoreTests.Repositories;

public class ItemRepository : IItemRepository
{
    public IList<IItem> GetAll()
    {
        return new List<IItem>
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