using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Models
{
    public class StandardItem : Item
    {
        public StandardItem(string name, int sellIn, int quality) 
            : base(name, sellIn, quality) { }
        public override void Update()
        {
            SellIn = SellIn - 1;
            Quality = Quality - 2;
            if (Quality < 0)
            {
                Quality = 0;
            }
            else if(Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}
