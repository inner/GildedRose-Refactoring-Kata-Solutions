using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Models
{
    public class Sulfuras : Item
    {
        public Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateSellIn()
        {
        }
    }
}
