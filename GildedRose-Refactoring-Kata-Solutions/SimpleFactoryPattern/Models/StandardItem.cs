using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Models
{
    public class StandardItem : Item
    {
        public StandardItem(string name, int sellIn, int quality) 
            : base(name, sellIn, quality) { }
        public override void UpdateQuality()
        {
            Quality = Quality - 2;
            base.UpdateQuality();
        }
    }
}
