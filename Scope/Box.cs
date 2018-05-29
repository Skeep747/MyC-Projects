using System;
using System.Drawing;
using System.Windows.Forms;

namespace Scope
{
    class Box
    {
        int sx = 1;
        int sy = 1;
        static int width, height;
        Graphics graph;

        enum Figure
        {
            line, circle
        };
        static Figure figure;
        static int line_x1, line_x2, line_y1, line_y2;
        static int circle_x, circle_y, circle_r;
        static Color color;
        static Random rand = new Random();

        public Box(Panel panel, int _sx, int _sy)
        {
            sx = _sx;
            sy = _sy;
            graph = panel.CreateGraphics();
        }

        public static void SetSize(int _width, int _height)
        {
            width = _width;
            height = _height;
        }

        public static void ChoiseFigure()
        {
            int f = rand.Next(0, Enum.GetNames(typeof(Figure)).Length);
            figure = (Figure)f;
            color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            switch (figure)
            {
                case Figure.line:
                    line_x1 = rand.Next(0, width);
                    line_x2 = rand.Next(0, width);
                    line_y1 = rand.Next(0, height);
                    line_y2 = rand.Next(0, height);
                    break;
                case Figure.circle:
                    circle_x = rand.Next(0, width);
                    circle_y = rand.Next(0, height);
                    circle_r = rand.Next(0, width / 4);
                    break;
            }
        }

        private void DrawLine()
        {
            Pen pen = new Pen(color);
            graph.DrawLine(pen, CX(line_x1), CY(line_y1), CX(line_x2), CY(line_y2));
        }

        private void DrawCircle()
        {
            Brush brush = new SolidBrush(color);
            graph.FillEllipse(brush, CX(circle_x) - circle_r, CY(circle_y) - circle_r, circle_r * 2, circle_r * 2);
        }

        public void DrowFigure()
        {
            switch (figure)
            {
                case Figure.line:
                    DrawLine();
                    break;
                case Figure.circle:
                    DrawCircle();
                    break;
            }
        }

        private int CX(int x)
        {
            return sx == 1 ? x : width - x;
        }

        private int CY(int y)
        {
            return sy == 1 ? y : height - y;
        }
    }
}
