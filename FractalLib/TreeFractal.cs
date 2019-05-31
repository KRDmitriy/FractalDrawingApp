using System;
using System.Collections.Generic;
using System.Drawing;

namespace Kara_79
{
    public class TreeFractal : Fractal
    {
        private readonly Color startColor;
        private readonly Color endColor;
        private readonly int depth;
        private readonly double corner = Math.PI / 2;
        private readonly double coef;
        private readonly double CornerL;
        private readonly double CornerR;
        private readonly int width;
        private readonly int heigth;
        private readonly List<Color> colorList;
        private List<Line> Lines;

        public TreeFractal(int width, int heigth, Color startColor, Color endColor,
            int depth, double coef,
                double CornerL, double CornerR)
        {
            this.width = width;
            this.heigth = heigth;
            this.startColor = startColor;
            this.endColor = endColor;
            this.depth = depth;
            this.coef = coef;
            this.CornerL = CornerL;
            this.CornerR = CornerR;
            colorList = GetColors(startColor, endColor, depth);
            Lines = new List<Line>();
        }

        public override void Draw()
        {
            DrawTreeFractal((float)(width * 0.5), (float)(heigth * 0.85),
                       heigth * 0.35 / (1 + coef), corner, depth);
        }

        /// <summary>
        /// Draws wind-blown fractal TreeFractal
        /// </summary>
        /// <param name="x">start x coordinate</param>
        /// <param name="y">start y coordinate</param>
        /// <param name="length">lenght of line</param>
        /// <param name="corner">how much we turn the line</param>
        /// <param name="rec">counter of the recursion</param>
        private void DrawTreeFractal(float x, float y, double length, double corner, int rec)
        {
            if (rec > 0 && length > double.Epsilon)
            {
                if (rec != depth)
                {
                    length *= coef;
                }

                //set new coordinates
                float newX = (float)Math.Round(x + length * Math.Cos(corner)),
                       newY = (float)Math.Round(y - length * Math.Sin(corner));

                //add line
                Lines.Add(new Line(newX, newY, x, y, colorList[depth - rec]));

                //Call recursive function for left and right
                DrawTreeFractal(newX, newY, length, corner + CornerL, rec - 1);
                DrawTreeFractal(newX, newY, length, corner - CornerR, rec - 1);
            }
        }

        public List<Line> GetLines => Lines;
    }
}
