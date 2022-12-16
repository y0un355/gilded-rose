using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Shop
    {
        private readonly ItemsRepository _itemsRepository;

        public Shop(ItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        public void UpdateQuality()
        {
            var items = _itemsRepository.GetInventory();
            foreach (Item i in items)
            {
                i.Update();
            }
            _itemsRepository.SaveInventory(items);
        }
    }
}
