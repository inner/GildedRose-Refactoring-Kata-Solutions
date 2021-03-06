﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class StandardStrategy : IStrategy
    {
        public (int sellIn, int quality) Update(Item item)
        {
            var quality = item.Quality - 2;
            return (item.SellIn - 1, Helper.ValidateQuality(quality));
        }
    }
}
