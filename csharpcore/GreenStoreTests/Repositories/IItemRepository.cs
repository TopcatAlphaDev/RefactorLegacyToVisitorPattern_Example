using System.Collections.Generic;
using GreenStore.Models;
using GreenStore.Models.Interfaces;

namespace GreenStoreTests.Repositories;

public interface IItemRepository
{
    IList<IItem> GetAll();
}