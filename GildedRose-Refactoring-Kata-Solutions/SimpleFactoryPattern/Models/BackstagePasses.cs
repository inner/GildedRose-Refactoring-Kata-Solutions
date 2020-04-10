using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Models
{
    public class BackstagePasses : Item
    {
        public BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality)
        {
        }

        public override void UpdateQuality()
        {
            // "Backstage passes", like aged brie, increases in Quality as its SellIn value approaches;
            // Quality increases by 2 when there are 10 days or less and by 3 when there are 5 days or less but
            // Quality drops to 0 after the concert
            if (SellIn < 0)
            {
                Quality = 0;
            }
            else if (SellIn <= 5)
            {
                Quality = Quality + 3;
            }
            else if (SellIn <= 10)
            {
                Quality = Quality + 2;
            }
            else
            {
                Quality = Quality + 1;
            }
            base.UpdateQuality();
        }
    }
}
