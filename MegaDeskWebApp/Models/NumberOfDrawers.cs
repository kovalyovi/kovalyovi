using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class NumberOfDrawers
    {
        private static Dictionary<string, int> PriceList = new Dictionary<string, int>()
        {
            { "0", 0 },
            { "1", 50 },
            { "2", 100 },
            { "3", 150 },
            { "4", 200 },
            { "5", 250 },
            { "6", 300 },
            { "7", 350 }
        };

        public static int GetMaterialPrice(string key)
        {
            return PriceList[key];
        }

        public static List<string> NumberNames()
        {
            return new List<string>(PriceList.Keys);
        }

        public static void ChangeMaterialPrice(string key, int price)
        {
            PriceList[key] = price;
        } 
    }
}
