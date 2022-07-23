using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void aged_brie_not_out_of_date_decrease_1_day_increase_1_quality()
        {
            int iSellIn = 20;
            int iQuality = 1;

            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = iSellIn, Quality = iQuality } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(iSellIn - 1, Items[0].SellIn);
            Assert.Equal(iQuality + 1, Items[0].Quality);
        }

        [Fact]
        public void aged_brie_quality_item_never_is_more_than_50()
        {
            int iSellIn = 20;
            int iQuality = 50;

            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = iSellIn, Quality = iQuality } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(iSellIn - 1, Items[0].SellIn);
            Assert.Equal(iQuality, Items[0].Quality);
        }

        [Fact]
        public void aged_brie_quality_increase_by_2_when_there_are_10_days_or_less()
        {
            int iSellIn = 10;
            int iQuality = 20;

            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = iSellIn, Quality = iQuality } };

            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(iSellIn-1, Items[0].SellIn);
            Assert.Equal(iQuality*2, Items[0].Quality);
        }

    }
}
