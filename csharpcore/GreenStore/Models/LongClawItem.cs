﻿using GreenStore.interfaces;
using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class LongClawItem : Item, IItem
    {
        public LongClawItem()
        {
            base.Name = "Longclaw";
        }
        public void Accept(IItemVisitor qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
