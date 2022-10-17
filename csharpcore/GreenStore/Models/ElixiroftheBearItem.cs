using GreenStore.Models.Interfaces;

namespace GreenStore.Models
{
    public class ElixiroftheBearItem : Item, IItem
    {
        public new string Name => "Elixir of the Bear";
        public void Accept(IQualityUpdater qualityUpdater)
        {
            qualityUpdater.Visit(this);
        }
    }
}
