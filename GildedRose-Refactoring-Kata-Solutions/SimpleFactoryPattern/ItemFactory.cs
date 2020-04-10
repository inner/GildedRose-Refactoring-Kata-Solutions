using System;
using System.Collections.Generic;
using System.Text;
using csharpcore.Models;

namespace csharpcore
{
    public class ItemFactory
    {
        public static Item CreateItem(string name, int sellIn, int quality)
        {
            switch (name)
            {
                case "Aged Brie":
                    return new AgedBrie(name, sellIn, quality);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagePasses(name, sellIn, quality);
                case "Sulfuras, Hand of Ragnaros":
                    return new Sulfuras(name, sellIn, quality);
                case "Conjured":
                    return new Conjured(name, sellIn, quality);
                default:
                    return new StandardItem(name, sellIn, quality);
            }
        }
    }
}
