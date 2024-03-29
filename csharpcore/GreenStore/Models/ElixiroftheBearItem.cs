﻿using GreenStore.interfaces;
using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class ElixiroftheBearItem : Item, IItem
    {
        public ElixiroftheBearItem()
        {
            base.Name = "Elixir of the Bear";
        }
        public void Accept(IItemVisitor qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
