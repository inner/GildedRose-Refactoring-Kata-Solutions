using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Models
{
    public class Conjured : Item
    {
        public Conjured(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void Update()
        {
            SellIn = SellIn - 1;
            // "Conjured" items degrade in Quality twice as fast as normal items
            Quality = Quality - 4;
            if (Quality < 0)
            {
                Quality = 0;
            }
            else if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}
