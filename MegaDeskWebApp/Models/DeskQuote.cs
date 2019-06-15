using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWebApp
{
    public class DeskQuote
    {
        
        public int ID { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Shipping Type")]
        public string ShippingType { get; set; }

        [Required]
        [Display(Name = "Quote Price")]
        public double QuotePrice { get; set; }

        public int DeskID { get; set; }
        public Desk Desk { get; set; }

        [Required]
        [Display(Name = "Rush Options")]
        public string RushOptions { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}
