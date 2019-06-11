using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        public string CustomerName;
        public string ShippingType;
        public double QuotePrice;
        public Desk Desk;
        public DateTime Date;

        public DeskQuote(string customerName, string shippingType, Desk desk, DateTime date)
        {
            this.CustomerName = customerName;
            this.ShippingType = shippingType;
            this.Desk = desk;
            this.Date = date;
            QuotePrice = GetQuote();
        }

        private double GetQuote()
        {
            float area = this.Desk.getArea();
            float extraArea = area > 1000 ? (area - 1000) * 1 : 0;
            int materialCost;

            switch (this.Desk.SurfaceMaterial)
            {
                case "oak":
                    materialCost = 200;
                    break;
                case "laminate":
                    materialCost = 100;
                    break;
                case "pine":
                    materialCost = 50;
                    break;
                case "rosewood":
                    materialCost = 300;
                    break;
                case "veneer":
                    materialCost = 125;
                    break;
                default:
                    materialCost = 0;
                    break;

            }

            String[] priceList = File.ReadAllLines("../rushOrderPrices.txt");
            
            int rushOrderPrice;
            if (area < 1000)
            {
                switch(this.ShippingType)
                {
                    case "3 day":
                        rushOrderPrice = int.Parse(priceList[0]);
                        break;
                    case "5 day":
                        rushOrderPrice = int.Parse(priceList[1]);
                        break;
                    case "7 day":
                        rushOrderPrice = int.Parse(priceList[2]);
                        break;
                    default:
                        rushOrderPrice = 0;
                        break;
                }
            }
            else if (area < 2000)
            {
                switch (this.ShippingType)
                {
                    case "3 day":
                        rushOrderPrice = int.Parse(priceList[3]);
                        break;
                    case "5 day":
                        rushOrderPrice = int.Parse(priceList[4]);
                        break;
                    case "7 day":
                        rushOrderPrice = int.Parse(priceList[5]);
                        break;
                    default:
                        rushOrderPrice = 0;
                        break;
                }
            }
            else
            {
                switch (this.ShippingType)
                {
                    case "3 day":
                        rushOrderPrice = int.Parse(priceList[6]);
                        break;
                    case "5 day":
                        rushOrderPrice = int.Parse(priceList[7]);
                        break;
                    case "7 day":
                        rushOrderPrice = int.Parse(priceList[8]);
                        break;
                    default:
                        rushOrderPrice = 0;
                        break;
                }
            }

            return 200.00 + 50 * Desk.NumberOfDrawers + extraArea + materialCost + rushOrderPrice;
        }
    }
}
