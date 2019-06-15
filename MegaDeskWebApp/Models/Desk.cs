using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MegaDeskWebApp
{
    public class Desk
    {
        public int DeskID { get; set; }

        [Required]
        public float Width { get; set; }

        [Required]
        public float Depth { get; set; }

        [Required]
        [Display(Name = "Number of Drawers")]
        public int NumberOfDrawers { get; set; }

        [Required]
        [Display(Name = "Surface Material")]
        public string SurfaceMaterial { get; set; }


    }
}
