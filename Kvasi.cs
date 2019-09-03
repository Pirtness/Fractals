using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractal
{
    public class Kvasi : Fractal
    {

        float direction; //direction on which there will be no circles

        /// <summary>
        /// Method to call private Draw1 
        /// </summary>
        /// <param name="x"> coordinate </param>
        /// <param name="y"> coordinate </param>
        /// <param name="graph"> where to draw </param>
        public override void Draw(float x, float y, ref Graphics graph)
        {
            Draw1(x, y, direction, ref graph);
        }

        /// <summary>
        /// Draw fractal
        /// </summary>
        /// <param name="x"> coordinate </param>
        /// <param name="y"> coordinate </param>
        /// <param name="direction"> direction </param>
        /// <param name="graph"> where to draw </param>
        void Draw1(float x, float y, float direction, ref Graphics graph)
        {
            graph.FillEllipse(GetBrush(currentDepth), x - length, y- length, 2 * length, 2 * length);
            if (currentDepth < maxDepth)
            {
                switch (direction)
                {
                    case 0:
                        currentDepth++;
                        length /= 2;
                        Draw1(x + 3 * length, y, 3, ref graph);
                        Draw1(x, y + 3 * length, 0, ref graph);
                        Draw1(x - 3 * length, y, 1, ref graph);
                        length *= 2;
                        currentDepth--;
                        break;
                    case 1:
                        currentDepth++;
                        length /= 2;
                        Draw1(x, y- 3 * length, 2, ref graph);
                        Draw1(x, y + 3 * length, 0, ref graph);
                        Draw1(x - 3 * length, y, 1, ref graph);
                        length *= 2;
                        currentDepth--;
                        break;
                    case 2:
                        currentDepth++;
                        length /= 2;
                        Draw1(x + 3 * length, y, 3, ref graph);
                        Draw1(x, y - 3 * length, 2, ref graph);
                        Draw1(x - 3 * length, y, 1, ref graph);
                        length *= 2;
                        currentDepth--;
                        break;
                    case 3:
                        currentDepth++;
                        length /= 2;
                        Draw1(x + 3 * length, y, 3, ref graph);
                        Draw1(x, y + 3 * length, 0, ref graph);
                        Draw1(x, y - 3 * length, 2, ref graph);
                        length *= 2;
                        currentDepth--;
                        break;

                }
            }
        }

        /// <summary>
        /// set initial values
        /// all fields has already been described
        /// </summary>
        /// <param name="maxDepth"></param>
        /// <param name="direction"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="length"></param>
        public Kvasi(int maxDepth, float direction, float x, float y, int length) : base(maxDepth, x, y)
        {
            this.direction = direction;
            this.length = length; //radius
            currentDepth = 1;
        }
    }
}
