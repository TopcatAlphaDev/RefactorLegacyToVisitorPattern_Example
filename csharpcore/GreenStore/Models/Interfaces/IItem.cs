using GreenStore.interfaces;

namespace GreenStore.Models.Interfaces;

public interface IItem
{
    void Accept(IItemVisitor qualityUpdater);

}