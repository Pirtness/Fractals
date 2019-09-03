using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Fractal
{
    /// <summary>
    /// Common class for fractals
    /// </summary>
    public abstract class Fractal
    {
        public Color startColor { private get; set; } //start color of the drawing
        public Color endColor { private get; set; } //end color of the drawing

        public float x // the X coordinate of the fractal in the picture
        {
            get;
            protected set;
        }
        public float y // the Y coordinate of the fractal in the picture
        {
            get;
            protected set;
        }

        protected int maxDepth; //max depth of the fractal
        protected int currentDepth; //current depth of the fractal
        public float length //length of the fractal element
        {
            get;
            protected set;
        }
        
        Color color = new Color(); //color of drawing

        /// <summary>
        /// Get color of the pen to draw the current layer
        /// </summary>
        /// <param name="curD">current depth</param>
        /// <returns> pen to draw </returns>
        public Pen GetPen(int curD)
        {
            if (maxDepth == 1)
                return new Pen(startColor);
            else
            {
                color = Color.FromArgb(
                    (endColor.A - startColor.A) / (maxDepth - 1) * (curD - 1) + startColor.A,
                    (endColor.R - startColor.R) / (maxDepth - 1) * (curD - 1) + startColor.R,
                    (endColor.G - startColor.G) / (maxDepth - 1) * (curD - 1) + startColor.G,
                    (endColor.B - startColor.B) / (maxDepth - 1) * (curD - 1) + startColor.B);
                return new Pen(color);
            }
        }

        /// <summary>
        /// Get color of the SolidBrush to draw the current layer
        /// </summary>
        /// <param name="curD"> current depth </param>
        /// <returns> SolidBrush to draw </returns>
        public SolidBrush GetBrush(int curD)
        {
            if (maxDepth == 1)
                return new SolidBrush(startColor);
            else
            {
                color = Color.FromArgb(
                    (endColor.A - startColor.A) / (maxDepth - 1) * (curD - 1) + startColor.A,
                    (endColor.R - startColor.R) / (maxDepth - 1) * (curD - 1) + startColor.R,
                    (endColor.G - startColor.G) / (maxDepth - 1) * (curD - 1) + startColor.G,
                    (endColor.B - startColor.B) / (maxDepth - 1) * (curD - 1) + startColor.B);
                return new SolidBrush(color);
            }
        }


        public abstract void Draw(float x, float y, ref Graphics graph);
        /// <summary>
        /// Set initial values
        /// </summary>
        /// <param name="maxDepth"> max depth </param>
        /// <param name="x"> x coordinate </param>
        /// <param name="y"> y coordinate </param>
        public Fractal(int maxDepth, float x, float y)
        {
            this.x = x;
            this.y = y;
            this.maxDepth = maxDepth;
        }
    }
}