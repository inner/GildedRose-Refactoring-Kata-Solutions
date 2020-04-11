using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class BackstagePassesStrategy : IStrategy
    {
        public (int sellIn, int quality) Update(Item item)
        {
            var sellIn = item.SellIn - 1;
            var quality = 0;
            if (sellIn < 0)
            {
                quality = 0;
            }
            else if (sellIn <= 5)
            {
                quality = item.Quality + 3;
            }
            else if (sellIn <= 10)
            {
                quality = item.Quality + 2;
            }
            else
            {
                quality = item.Quality + 1;
            }
            return (sellIn, Helper.ValidateQuality(quality));
        }
    }
}
