using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp.Models
{
    public class MaterialPrice
    {
        private static Dictionary<string, int> PriceList = new Dictionary<string, int>()
        {
            { "Oak", 200 },
            { "Laminate", 100 },
            { "Pine", 50 },
            { "Rosewood", 300 },
            { "Veneer", 125 }
        };

        public static int GetMaterialPrice(string key)
        {
            return PriceList[key];
        }

        public static List<string> MaterialNames()
        {
            return new List<string>(PriceList.Keys);
        }

        public static void ChangeMaterialPrice(string key, int price)
        {
            PriceList[key] = price;
        }
    }

}
