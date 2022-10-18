using System.Collections.Generic;
using GreenStore.interfaces;
using GreenStore.Models;
using GreenStore.Models.Interfaces;

namespace GreenStore
{
    public class QualityUpdater : IQualityUpdater,IItemVisitor
    {
        private readonly IList<IItem> _items;
        public QualityUpdater(IList<IItem> items)
        {
            _items = items;
        }

        public void DoUpdate()
        {
            foreach (var item in _items)
            {
                item.Accept(this);
            }
        }

        public void Visit(LongClawItem item)
        {
            UpdateQuality(item);
        }
        public void Visit(AgedCheddarItem item)
        {
            UpdateQuality(item);
        }
        public void Visit(Plus3AgilityVestItem item)
        {
            UpdateQuality(item);
        }

        public void Visit(ConjuredCharismaPotionItem item)
        {
            UpdateQuality(item);
        }

        public void Visit(ElixiroftheBearItem item)
        {
            UpdateQuality(item);
        }
        public void Visit(ViPTicketsToASamuraiConcertItem item)
        {
            UpdateQuality(item);
        }
        private static void UpdateQuality(Item item)
        {
            if (item.GetType() != typeof(AgedCheddarItem) && item.GetType() != typeof(ViPTicketsToASamuraiConcertItem))
            {
                if (item.Quality > 0)
                {
                    if (typeof(LongClawItem) != item.GetType())
                    {
                        item.Quality -= 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality += 1;

                    if (item.GetType() == typeof(ViPTicketsToASamuraiConcertItem))
                    {
                        if (item.SellIn < 11)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality += 1;
                            }
                        }

                        if (item.SellIn < 6)
                        {
                            if (item.Quality < 50)
                            {
                                item.Quality += 1;
                            }
                        }
                    }
                }
            }

            if (typeof(LongClawItem) != item.GetType())
            {
                item.SellIn -= 1;
            }

            if (item.SellIn < 0)
            {
                if (item.GetType() != typeof(AgedCheddarItem))
                {
                    if (item.GetType() != typeof(ViPTicketsToASamuraiConcertItem))
                    {
                        if (item.Quality > 0)
                        {
                            if (typeof(LongClawItem) != item.GetType())
                            {
                                item.Quality -= 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality -= item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality += 1;
                    }
                }
            }
        }


    }
}
