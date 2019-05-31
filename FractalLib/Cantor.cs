using System.Collections.Generic;
using System.Drawing;

namespace Kara_79
{
    public class Cantor : Fractal
    {
        private readonly int width;
        private readonly int height;
        private readonly Color startColor;
        private readonly Color endColor;
        private readonly float distance;
        private readonly int depth;
        private readonly List<Color> colorList;
        private List<Rectangle> rectangles;

        public Cantor(int width, int height, Color startColor, Color endColor,
            int depth, float distance)
        {
            this.width = width;
            this.height = height;
            this.startColor = startColor;
            this.endColor = endColor;
            this.depth = depth;
            colorList = Fractal.GetColors(startColor, endColor, depth);
            rectangles = new List<Rectangle>();
            this.distance = distance;
        }

        public override void Draw()
        {
            DrawCantor((float)(width * 0.03), (float)(height * 0.1), (float)(width * 0.94), depth);
        }

        /// <summary>
        /// Draw Cantor's lot
        /// </summary>
        /// <param name="x">start X value</param>
        /// <param name="y">start Y value</param>
        /// <param name="width">width of blocks</param>
        /// <param name="rec">depth of recursion</param>
        private void DrawCantor(float x, float y, float width, int rec)
        {
            //width > 1 because if (width > 0 and width < 1) width automatically set as 1
            if (width > 0 && rec > 0)
            {
                //add rectangle
                rectangles.Add(new Rectangle(x, y, width, (distance / 2), colorList[depth - rec]));

                y = y + distance;

                //call next
                DrawCantor(x + width * 2 / 3, y, width / 3, rec - 1);
                DrawCantor(x, y, width / 3, rec - 1);
            }
        }

        public List<Rectangle> GetRectangles => rectangles;
    }
}
