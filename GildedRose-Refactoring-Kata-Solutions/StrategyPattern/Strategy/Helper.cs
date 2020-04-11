﻿using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Strategy
{
    public class Helper
    {
        public static int ValidateQuality(int quality)
        {
            if (quality < 0)
            {
                quality = 0;
            }
            else if (quality > 50)
            {
                quality = 50;
            }
            return quality;
        }
    }
}
