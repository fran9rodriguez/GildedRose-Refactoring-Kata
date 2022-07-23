using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class FactoryItem
    {
        private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const string CONJURED = "Conjured Mana Cake";

        public static ParentItem GetItem(Item item)
        {
            switch (item.Name)
            {
                case AGED_BRIE:
                    return new AgedBrie(item);                    
                case BACKSTAGE_PASSES:
                    return new BackstagePasses(item);                  
                case SULFURAS:
                    return new Sulfuras(item);                   
                case CONJURED:
                    return new Conjured(item);                   
                default:
                    return new StandardItem(item);                  

            }
        }

    }
}
