using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visor
{
    internal class Canvas
    {
        private Graphics g;
        private Bitmap bmp;

        public Canvas(Graphics graphics, Bitmap bitmap)
        {
            g = graphics;
            bmp = bitmap;
        }

        public void Renderplane()
        {
            int width = bmp.Width;
            int height = bmp.Height;

            g.DrawLine(Pens.Yellow, new Point(0, height / 2), new Point(width, height / 2));
            g.DrawLine(Pens.Yellow, new Point(width / 2, 0), new Point(width / 2, height));
        }

        public void RenderFigura(Figura figura)
        {
            for (int i = 0; i < figura.vertices.Count; i++)
            {
                Point start = figura.vertices[i];
                Point end = figura.vertices[(i + 1) % figura.vertices.Count];
                g.DrawLine(Pens.Red, start, end);
            }
        }

        public void Clear()
        {
            g.Clear(Color.Black);
        }
    }
}
