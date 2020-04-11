using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class AgedBrieStrategy : IStrategy
    {
        public (int sellIn, int quality) Update(Item item)
        {
            var quality = item.Quality + 1;
            return (item.SellIn - 1, Helper.ValidateQuality(quality));
        }
    }
}
