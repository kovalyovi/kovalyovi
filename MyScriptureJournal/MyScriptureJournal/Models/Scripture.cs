using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int verseStart { get; set; }
        public int verseEnd { get; set; }
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }


    }
}
