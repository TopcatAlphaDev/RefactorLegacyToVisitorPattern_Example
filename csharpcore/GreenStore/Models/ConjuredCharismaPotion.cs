using GreenStore.interfaces;
using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class ConjuredCharismaPotionItem : Item, IItem
    {
        public new string Name => "Conjured Charisma Potion";
        public void Accept(IItemVisitor qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
