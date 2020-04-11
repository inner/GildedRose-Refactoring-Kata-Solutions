using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class SulfurasStrategy : IStrategy
    {
        public (int sellIn, int quality) Update(Item item)
        {
            return (item.SellIn, Helper.ValidateQuality(item.Quality));
        }
    }
}
