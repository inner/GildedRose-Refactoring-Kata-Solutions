using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class StrategyContext
    {
        private readonly IStrategy _strategy = null;

        public StrategyContext(string name)
        {
            switch (name)
            {
                case "Aged Brie":
                    _strategy = new AgedBrieStrategy();
                    break;
                case "Backstage passes to a TAFKAL80ETC concert":
                    _strategy = new BackstagePassesStrategy();
                    break;
                case "Sulfuras, Hand of Ragnaros":
                    _strategy = new SulfurasStrategy();
                    break;
                case "Conjured Mana Cake":
                    _strategy = new ConjuredStrategy();
                    break;
                default:
                    _strategy = new StandardStrategy();
                    break;
            }
        }

        public (int sellIn, int quality) Update(Item item)
        {
            return _strategy.Update(item);
        }

    }
}
