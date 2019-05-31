using System.Collections.Generic;
using System.Drawing;

namespace Kara_79
{
    public class Levi : Fractal
    {
        private readonly Color startColor;
        private readonly Color endColor;
        private readonly int depth;
        private List<Line> Lines;
        private readonly int width;
        private readonly int heigth;
        private readonly List<Color> colorList;

        public Levi(int width, int heigth, Color startColor, Color endColor, int depth)
        {
            this.startColor = startColor;
            this.endColor = endColor;
            this.depth = depth;
            this.width = width;
            this.heigth = heigth;
            colorList = GetColors(startColor, endColor, depth);
            Lines = new List<Line>();
        }

        public override void Draw()
        {
            DrawLevy((float)(width * 0.7), (float)(heigth * 0.75),
                        (float)(width * 0.7), (float)(heigth * 0.25), depth - 1);
        }

        /// <summary>
        /// Draw Levi's curve
        /// </summary>
        /// <param name="oldX">start X</param>
        /// <param name="oldY">start Y</param>
        /// <param name="x">end X</param>
        /// <param name="y">end Y</param>
        /// <param name="rec">depth of recursion</param>
        private void DrawLevy(float oldX, float oldY, float x, float y, int rec)
        {
            if (rec == 0)
            {
                //add line
                Lines.Add(new Line(x, y, oldX, oldY, endColor));
            }
            else
            {
                //set new coordinates
                float newX = (oldX + x) / 2 + (y - oldY) / 2;
                float newY = (oldY + y) / 2 - (x - oldX) / 2;

                //call left and rigth recursion
                DrawLevy(oldX, oldY, newX, newY, rec - 1);
                DrawLevy(newX, newY, x, y, rec - 1);
            }
        }

        public List<Line> GetLines => Lines;
    }
}
