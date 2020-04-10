using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Models
{
    public class AgedBrie : Item
    {
        public AgedBrie(string name, int sellIn, int quality) 
            : base(name, sellIn, quality)
        {
        }

        public override void Update()
        {
            SellIn = SellIn - 1;
            Quality = Quality + 1;
            if (Quality < 0)
            {
                Quality = 0;
            }
            else if (Quality > 50)
            {
                //The Quality of an item is never more than 50
                Quality = 50;
            }
        }
    }
}
