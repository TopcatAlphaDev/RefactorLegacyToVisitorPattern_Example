using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class LongClawItem : Item, IItem
    {
        public new string Name => "Longclaw";
        public void Accept(IQualityUpdater qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
