using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class SulfurasStrategy : IStrategy
    {
        public (int sellIn, int quality) Update(Item item)
        {
            var quality = 0;
            if (item.Quality < 0)
            {
                quality = 0;
            }
            else if (item.Quality > 50)
            {
                quality = 50;
            }
            return (item.SellIn, quality);
        }
    }
}
