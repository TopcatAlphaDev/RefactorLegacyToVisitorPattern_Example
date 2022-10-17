using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class AgedCheddarItem : Item, IItem
    {
        public new string Name => "Aged Cheddar";
        public void Accept(IQualityUpdater qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
