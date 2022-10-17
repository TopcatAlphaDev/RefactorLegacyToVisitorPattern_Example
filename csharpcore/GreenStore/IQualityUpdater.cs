using GreenStore.Models;

namespace GreenStore;

public interface IQualityUpdater
{
    void DoUpdate();
    void Visit(LongClawItem item);
    void Visit(AgedCheddarItem item);
    void Visit(Plus3AgilityVestItem item);
    void Visit(ConjuredCharismaPotionItem item);
    void Visit(ElixiroftheBearItem item);
    void Visit(ViPTicketsToASamuraiConcertItem item);
}