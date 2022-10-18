using GreenStore.interfaces;
using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class Plus3AgilityVestItem : Item, IItem
    {
        public Plus3AgilityVestItem()
        {
            base.Name = "+3 Agility Vest";
        }
        public void Accept(IItemVisitor qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
