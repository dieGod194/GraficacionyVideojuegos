using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visor
{
    internal class Figura
    {
        public List<Point> vertices;

        public Figura(params Point[] puntos)
        {
            vertices = new List<Point>(puntos);
        }
        public static Figura CrearCuadrado(int centerX, int centerY, int lado)
        {
            Point[] puntosCuadrado = new Point[]
            {
            new Point(centerX - lado / 2, centerY - lado / 2),
            new Point(centerX + lado / 2, centerY - lado / 2),
            new Point(centerX + lado / 2, centerY + lado / 2),
            new Point(centerX - lado / 2, centerY + lado / 2)
            };

            return new Figura(puntosCuadrado);
        }

        public static Figura CrearTriangulo(int centerX, int centerY, int lado)
        {
            Point[] puntosTriangulo = new Point[]
            {
            new Point(centerX, centerY - lado / 2),
            new Point(centerX + lado / 2, centerY + lado / 2),
            new Point(centerX - lado / 2, centerY + lado / 2)
            };

            return new Figura(puntosTriangulo);
        }

        public void Rotar(double angle)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i] = new Point
                {
                    X = (int)((vertices[i].X * Math.Cos(angle)) - (vertices[i].Y * Math.Sin(angle))),
                    Y = (int)((vertices[i].X * Math.Sin(angle)) + (vertices[i].Y * Math.Cos(angle)))
                };
            }
        }


        public void Trasladar(int deltaX, int deltaY)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i] = new Point
                {
                    X = vertices[i].X + deltaX,
                    Y = vertices[i].Y - deltaY
                };
            }
        }

        public void Escalar(double factor)
        {
            for (int i = 0; i < vertices.Count; i++)
            {
                vertices[i] = new Point
                {
                    X = (int)(vertices[i].X * factor),
                    Y = (int)(vertices[i].Y * factor)
                };
            }
        }


    }
}
