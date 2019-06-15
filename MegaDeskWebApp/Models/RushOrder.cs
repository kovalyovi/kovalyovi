using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class RushOrder
    {
        private static string[] OrderOptions = new string[] { "3 Day", "5 Day", "7 Day", "Regular" };

        private static Dictionary<string, int> SmallSurface = new Dictionary<string, int>()
        {
            { OrderOptions[0], 60 },
            { OrderOptions[1], 70 },
            { OrderOptions[2], 80 },
            { OrderOptions[3], 0 }

        };

        private static Dictionary<string, int> MediumSurface = new Dictionary<string, int>()
        {
            { OrderOptions[0], 40 },
            { OrderOptions[1], 50 },
            { OrderOptions[2], 60 },
            { OrderOptions[3], 0 }
        };

        private static Dictionary<string, int> LargeSurface = new Dictionary<string, int>()
        {
            { OrderOptions[0], 30 },
            { OrderOptions[1], 35 },
            { OrderOptions[2], 40 },
            { OrderOptions[3], 0 }
        };

        public static int CalculateRushOrder(string key, int size)
        {
            if (size < 1000)
                return SmallSurface[key];
            else if (size < 2000)
                return MediumSurface[key];
            else
                return LargeSurface[key];
        }

        public static List<string> GetOrderOptions()
        {
            return new List<string>(SmallSurface.Keys);
        }
    }

}
