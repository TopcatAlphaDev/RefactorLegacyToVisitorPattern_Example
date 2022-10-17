using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class Plus3AgilityVestItem : Item, IItem
    {
        public new string Name => "+3 Agility Vest";
        public void Accept(IQualityUpdater qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
