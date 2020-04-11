using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace csharpcore.Strategy
{
    public interface IStrategy
    {
        (int sellIn, int quality) Update(Item item);
    }
}
