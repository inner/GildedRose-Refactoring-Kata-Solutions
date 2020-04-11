using System.Collections.Generic;
using csharpcore.Strategy;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var context = new StrategyContext(item.Name);
                var result = context.Update(item);
                item.SellIn = result.sellIn;
                item.Quality = result.quality;
            }
        }
    }
}
