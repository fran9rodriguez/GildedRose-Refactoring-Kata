using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata;

namespace GildedRoseKata
{
    public abstract class ParentItem
    {
        private Item _item;
        private const int qualityLimit = 50;

        public ParentItem() { }

        public ParentItem(Item item)
        {
            _item = item;
            item.SellIn--;
        }       

        public bool isOutOfDate(Item item)
        {
            if (item.SellIn < 1) return true;
            else return false;
        }

        public bool isQualityGreaterOrEqualThanLimit(Item item)
        {
            if (item.Quality > qualityLimit - 1) return true;
            else return false;
        }
    }
}
