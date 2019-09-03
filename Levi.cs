using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractal
{
    public class Levi : Fractal
    {
        int direction; //direction of drawing

        /// <summary>
        /// To call private Draw2
        /// </summary>
        /// <param name="x"> coordinate </param>
        /// <param name="y"> coordinate </param>
        /// <param name="graph"> where to draw </param>
        public override void Draw(float x, float y, ref Graphics graph)
        {
            Draw2(x, y, x, y-length/ (float)Math.Sqrt(2), direction, ref graph);
        }

        /// <summary>
        /// Draw fractal
        /// </summary>
        /// <param name="x"> coordinate </param>
        /// <param name="y"> coordinate </param>
        /// <param name="x2"> coordinate </param>
        /// <param name="y2"> coordinate </param>
        /// <param name="direction"> direction </param>
        /// <param name="graph"> where to draw </param>
        void Draw2(float x, float y, float x2, float y2, int direction, ref Graphics graph)
        {
            graph.DrawLine(GetPen(currentDepth), x, y, x2, y2);
            if (currentDepth < maxDepth)
            {
                switch (direction)
                {
                    case 0:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x + length / 2, y - length / 2, 7, ref graph);
                        Draw2(x + length / 2, y - length / 2, x + length, y, 1, ref graph);
                        length *= (float)Math.Sqrt(2);
                        currentDepth--;
                        break;
                    case 1:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x + length / (float)Math.Sqrt(2), y, 0, ref graph);
                        Draw2(x + length / (float)Math.Sqrt(2), y, x + length / (float)Math.Sqrt(2), y + length / (float)Math.Sqrt(2), 2, ref graph);
                        length *= (float)Math.Sqrt(2);
                        currentDepth--;
                        break;
                    case 2:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x + length / 2, y + length / 2, 1, ref graph);
                        Draw2(x + length / 2, y + length / 2, x, y + length, 3, ref graph);
                        length *= (float)Math.Sqrt(2);
                        currentDepth--;
                        break;
                    case 3:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x, y + length / (float)Math.Sqrt(2), 2, ref graph);
                        Draw2(x, y + length / (float)Math.Sqrt(2), x - length / (float)Math.Sqrt(2), y + length / (float)Math.Sqrt(2), 4, ref graph);
                        length *= (float)Math.Sqrt(2);
                        currentDepth--;
                        break;
                    case 4:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x - length / 2, y + length / 2, 3, ref graph);
                        Draw2(x - length / 2, y + length / 2, x - length, y, 5, ref graph);
                        length *= (float)Math.Sqrt(2);
                        currentDepth--;
                        break;
                    case 5:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x - length / (float)Math.Sqrt(2), y, 4, ref graph);
                        Draw2(x - length / (float)Math.Sqrt(2), y, x - length/ (float)Math.Sqrt(2), y - length/ (float)Math.Sqrt(2), 6, ref graph);
                        length *= (float)Math.Sqrt(2);
                        currentDepth--;
                        break;
                    case 6:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x - length / 2, y - length / 2, 5, ref graph);
                        Draw2(x - length / 2, y - length / 2, x, y - length, 7, ref graph);
                        currentDepth--;
                        length *= (float)Math.Sqrt(2);
                        break;
                    case 7:
                        currentDepth++;
                        length /= (float)Math.Sqrt(2);
                        Draw2(x, y, x, y - length / (float)Math.Sqrt(2), 6, ref graph);
                        Draw2(x, y - length / (float)Math.Sqrt(2), x + length/ (float)Math.Sqrt(2), y - length/(float)Math.Sqrt(2), 0, ref graph);
                        currentDepth--;
                        length *= (float)Math.Sqrt(2);
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
        public Levi(int maxDepth, int direction, float x, float y, int length) : base(maxDepth, x, y)
        {
            this.direction = direction;
            this.length = length * (float)Math.Sqrt(2); //radius
            currentDepth = 1;
        }
    }
}
