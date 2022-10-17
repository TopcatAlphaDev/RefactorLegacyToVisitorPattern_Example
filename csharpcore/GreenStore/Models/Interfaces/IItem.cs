namespace GreenStore.Models.Interfaces;

public interface IItem
{
    void Accept(IQualityUpdater qualityUpdater);

}