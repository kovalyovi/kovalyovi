using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Desk
    {
        public float Width;
        public float Depth;
        public int NumberOfDrawers;
        public string SurfaceMaterial;

        public enum DeskMaterial
        {
            oak = 1,
            wood = 2
        }

        public Desk(float width, float depth, int numberOfDrawers, string surfaceMaterial)
        {
            this.Width = width;
            this.Depth = depth;
            this.NumberOfDrawers = numberOfDrawers;
            this.SurfaceMaterial = surfaceMaterial;
        }

        public float getArea()
        {
            return this.Width * this.Depth;
        }


    }
}
