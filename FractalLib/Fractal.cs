using System.Collections.Generic;
using System.Drawing;


namespace Kara_79
{
    public abstract class Fractal
    {
        /// <summary>
        /// Struct of line (coordinates and color) 
        /// </summary>
        public struct Line
        {
            private readonly float x;
            private readonly float y;
            private readonly float oldX;
            private readonly float oldY;
            private readonly Color color;

            public float X => x;
            public float Y => y;
            public float OldX => oldX;
            public float OldY => oldY;
            public Color Color => color;

            public Line(float x, float y, float oldX, float oldY, Color color)
            {
                this.x = x;
                this.y = y;
                this.oldX = oldX;
                this.oldY = oldY;
                this.color = color;
            }
        }

        /// <summary>
        /// Struct of rectangle (x, y, width, height, color)
        /// </summary>
        public struct Rectangle
        {
            private readonly float x;
            private readonly float y;
            private readonly float width;
            private readonly float height;
            private readonly Color color;

            public float X => x;
            public float Y => y;
            public float Width => width;
            public float Heigth => height;
            public Color Color => color;

            public Rectangle(float x, float y, float width, float height, Color color)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
                this.color = color;
            }
        }

        /// <summary>
        /// Create List of colors(depends on depth of the recursion)
        /// </summary>
        /// <param name="startColor">Start color</param>
        /// <param name="endColor">Final color</param>
        /// <param name="depth">depth of recursion</param>
        /// <returns>New List of Colors</returns>
        public static List<Color> GetColors(Color startColor, Color endColor, int depth)
        {
            List<Color> colorList = new List<Color>();
            if (depth == 1)
            {
                colorList.Add(startColor);
                return colorList;
            }
            int rMax = endColor.R;
            int bMax = endColor.B;
            int gMax = endColor.G;
            int rMin = startColor.R;
            int bMin = startColor.B;
            int gMin = startColor.G;
            for (int i = 0; i < depth; i++)
            {
                int rAverage = rMin + (rMax - rMin) * i / (depth - 1);
                int gAverage = gMin + (gMax - gMin) * i / (depth - 1);
                int bAverage = bMin + (bMax - bMin) * i / (depth - 1);
                colorList.Add(Color.FromArgb(255, (byte)rAverage,
                    (byte)gAverage, (byte)bAverage));
            }
            return colorList;
        }

        public abstract void Draw();
    }
}
