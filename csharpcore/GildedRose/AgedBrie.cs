using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata;

namespace GildedRoseKata
{
    public class AgedBrie: ParentItem
    {
        public AgedBrie(Item item) : base(item)
        {
            if (!base.isOutOfDate(item) && !base.isQualityGreaterOrEqualThanLimit(item))
            {                
                item.Quality++;

            }          
            
        }

        
    }
}
