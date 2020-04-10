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

        public override void UpdateQuality()
        {
            Quality = Quality + 1;
            base.UpdateQuality();
        }
    }
}
