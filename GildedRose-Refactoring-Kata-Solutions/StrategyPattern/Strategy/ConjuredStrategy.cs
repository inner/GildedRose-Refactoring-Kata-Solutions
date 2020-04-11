using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class ConjuredStrategy : IStrategy
    {
        public (int sellIn, int quality) Update(Item item)
        {
            var quality = item.Quality - 4;
            return (item.SellIn - 1, Helper.ValidateQuality(quality));
        }
    }
}
