using GreenStore.Models;

namespace GreenStore.interfaces;

public interface IItemVisitor
{
    void Visit(LongClawItem item);
    void Visit(AgedCheddarItem item);
    void Visit(Plus3AgilityVestItem item);
    void Visit(ConjuredCharismaPotionItem item);
    void Visit(ElixiroftheBearItem item);
    void Visit(ViPTicketsToASamuraiConcertItem item);
}