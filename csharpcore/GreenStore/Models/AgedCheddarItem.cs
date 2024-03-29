﻿using GreenStore.interfaces;
using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class AgedCheddarItem : Item, IItem
    {
        public AgedCheddarItem()
        {
            base.Name = "Aged Cheddar";
        }
        public void Accept(IItemVisitor qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
