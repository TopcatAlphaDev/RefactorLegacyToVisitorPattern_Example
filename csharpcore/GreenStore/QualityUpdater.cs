using System.Collections.Generic;
using GreenStore.Models;

namespace GreenStore
{
    public class QualityUpdater
    {
        private readonly IList<Item> _items;
        public QualityUpdater(IList<Item> items)
        {
            _items = items;
        }

        public void DoUpdate()
        {
            for (var i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name != "Aged Cheddar" && _items[i].Name != "VIP tickets to a Samurai concert")
                {
                    if (_items[i].Quality > 0)
                    {
                        if (typeof(LongClawItem) != _items[i].GetType())
                        {
                            _items[i].Quality -= 1;
                        }
                    }
                }
                else
                {
                    if (_items[i].Quality < 50)
                    {
                        _items[i].Quality += 1;

                        if (_items[i].Name == "VIP tickets to a Samurai concert")
                        {
                            if (_items[i].SellIn < 11)
                            {
                                if (_items[i].Quality < 50)
                                {
                                    _items[i].Quality += 1;
                                }
                            }

                            if (_items[i].SellIn < 6)
                            {
                                if (_items[i].Quality < 50)
                                {
                                    _items[i].Quality += 1;
                                }
                            }
                        }
                    }
                }

                if (typeof(LongClawItem) != _items[i].GetType())
                {
                    _items[i].SellIn -= 1;
                }

                if (_items[i].SellIn < 0)
                {
                    if (_items[i].Name != "Aged Cheddar")
                    {
                        if (_items[i].Name != "VIP tickets to a Samurai concert")
                        {
                            if (_items[i].Quality > 0)
                            {
                                if (typeof(LongClawItem) != _items[i].GetType())
                                {
                                    _items[i].Quality -= 1;
                                }
                            }
                        }
                        else
                        {
                            _items[i].Quality -= _items[i].Quality;
                        }
                    }
                    else
                    {
                        if (_items[i].Quality < 50)
                        {
                            _items[i].Quality += 1;
                        }
                    }
                }
            }
        }
    }
}
