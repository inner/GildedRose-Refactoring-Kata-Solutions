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

        public override void UpdateQuality()
        {
            // "Conjured" items degrade in Quality twice as fast as normal items
            Quality = Quality - 4;
            base.UpdateQuality();
        }
    }
}
