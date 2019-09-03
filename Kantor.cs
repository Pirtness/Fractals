using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal
{
    public class Kantor : Fractal
    {
        private float distance; // distance between lines
        private int height; //height of lines
        
        /// <summary>
        /// Draw fractal
        /// </summary>
        /// <param name="x"> x coordinate </param>
        /// <param name="y"> y coordinate </param>
        /// <param name="graph"> where to draw </param>
        public override void Draw(float x, float y, ref Graphics graph)
        {
            graph.FillRectangle(GetBrush(currentDepth), x, y, length, height);
            if (currentDepth < maxDepth)
            {
                currentDepth++;
                length /= 3;
                y += distance + height;
                Draw(x, y, ref graph);
                Draw(x + 2*length, y, ref graph);
                y -= (distance + height);
                currentDepth--;
                length *= 3;
            }
        }

        /// <summary>
        /// set initial values
        /// all fields has already been described
        /// </summary>
        /// <param name="maxDepth"></param>
        /// <param name="distance"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="length"></param>
        /// <param name="height"></param>
        public Kantor (int maxDepth, float distance, float x, float y, float length, int height) : base(maxDepth, x, y)
        {
            this.distance = distance;
            this.length = length;
            this.height = height;
            currentDepth = 1;
        }

    }
}
