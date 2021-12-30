using System;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories {
     public interface IItemsrespository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}