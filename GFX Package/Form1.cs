using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GFX_Package
{
    public partial class Form1 : Form
    {
        Bitmap image1 = new Bitmap(@"F:\2-Computer Science's shit\4-college\LEVEL 3 TERM 2\GFX\gfxbitmap.bmp", true);
        int IMAGE_HEIGHT = 250;
        int IMAGE_WIDTH = 250;
        int IMAGE_REMAP_FACTOR = 125;
        Color PEN_COLOR = Color.Black;
        Color BACKGROUND_COLOR = ColorTranslator.FromHtml("#C2DCF1");
        Color HIGHLIGHT_cOLOR = Color.Yellow;
        Color SECONDARY_COLOR = ColorTranslator.FromHtml("#40B5E5");
        List<Shape> shapesHistory = new List<Shape>();
        List<Point> highlightHistory = new List<Point>();
        bool isNewShape = false;
        bool needShape = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntializeImage();
        }

        public void IntializeImage()
        {

            int x, y;

            for (x = 0; x < IMAGE_WIDTH; x++)
            {
                for (y = 0; y < IMAGE_HEIGHT; y++)
                {
                    if (y % 25 == 0 || x % 25 == 0)
                    {
                        image1.SetPixel(x, y, SECONDARY_COLOR);
                    }
                    else
                    {
                        image1.SetPixel(x, y, BACKGROUND_COLOR);
                    }
                }
            }

            pictureBox1.Image = image1;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            isNewShape = true;
            if (radioDDA.Checked)
            {
                shapesHistory.Add(DDA(new Point(Int32.Parse(startX.Text) + IMAGE_REMAP_FACTOR, Int32.Parse(startY.Text) + IMAGE_REMAP_FACTOR), new Point(Int32.Parse(endX.Text) + IMAGE_REMAP_FACTOR, Int32.Parse(endY.Text) + IMAGE_REMAP_FACTOR), PEN_COLOR));
            }
            else if (radioBresh.Checked)
            {
                shapesHistory.Add(Bresenham(new Point(Int32.Parse(startX.Text + IMAGE_REMAP_FACTOR), Int32.Parse(startY.Text) + IMAGE_REMAP_FACTOR), new Point(Int32.Parse(endX.Text) + IMAGE_REMAP_FACTOR, Int32.Parse(endY.Text) + IMAGE_REMAP_FACTOR), PEN_COLOR));
            }
            else if (radioCircle.Checked)
            {
                shapesHistory.Add(DrawCircle(new Point(Int32.Parse(centerX.Text) + IMAGE_REMAP_FACTOR, Int32.Parse(centerY.Text) + IMAGE_REMAP_FACTOR), Int32.Parse(radius.Text), PEN_COLOR));
            }
            else if (radioEllipse.Checked)
            {
                shapesHistory.Add(DrawEllipse(new Point(Int32.Parse(centerX.Text) + IMAGE_REMAP_FACTOR, Int32.Parse(centerY.Text) + IMAGE_REMAP_FACTOR), Int32.Parse(radius.Text), Int32.Parse(radiusY.Text), PEN_COLOR));

            }
            else if (radioRect.Checked)
            {
                shapesHistory.Add(DrawRect(new Point(Int32.Parse(centerX.Text) + IMAGE_REMAP_FACTOR, Int32.Parse(centerY.Text) + IMAGE_REMAP_FACTOR), Int32.Parse(lengthTxt.Text), Int32.Parse(widthTxt.Text), PEN_COLOR));

            }
            else if (radioSquare.Checked)
            {
                shapesHistory.Add(DrawRect(new Point(Int32.Parse(centerX.Text) + IMAGE_REMAP_FACTOR, Int32.Parse(centerY.Text) + IMAGE_REMAP_FACTOR), Int32.Parse(sideTxt.Text), Int32.Parse(sideTxt.Text), PEN_COLOR));
            }
            int lastIndex = shapesHistory.Count - 1;
            Shape lastShape = shapesHistory[lastIndex];
            if (lastShape.GetType() == typeof(Circle))
            {
                Circle c = (Circle)lastShape;
                log((lastIndex) + " | Center : " + c.center + " | Radius : " + c.radius);
            }
            else if (lastShape.GetType() == typeof(Ellipse))
            {
                Ellipse el = (Ellipse)lastShape;
                log((lastIndex) + " | Center : " + el.center + " | rx : " + el.radiusX + " | ry : " + el.radiusY);
            }
            else if (lastShape.GetType() == typeof(Rect))
            {
                Rect r = (Rect)lastShape;
                log((lastIndex) + " | startCorner : " + r.startCorner + " | L : " + r.length + " | W : " + r.width);
            }
            else if (lastShape.GetType() == typeof(Shape))
            {
                log((lastIndex) + " | start pt :" + lastShape.points[0] + " | end pt :" + lastShape.points[lastShape.points.Count - 1]);
            }

            if (highlightHistory.Count < 1)
            {
                HighlightPexels(shapesHistory[0].points, HIGHLIGHT_cOLOR);
                highlightHistory = shapesHistory[0].points;
            }
            UpdateImage();

        }

        private void transformBtn_Click(object sender, EventArgs e)
        {
            isNewShape = false;
            if (Int32.Parse(shapeIndexTxt.Text) >= shapesHistory.Count && needShape)
            {
                log("Selected Shape is non existing");
                return;
            }
            bool isCircle = shapesHistory[Int32.Parse(shapeIndexTxt.Text)].GetType() == typeof(Circle);
            bool isEllipse = shapesHistory[Int32.Parse(shapeIndexTxt.Text)].GetType() == typeof(Ellipse);
            bool isRect = shapesHistory[Int32.Parse(shapeIndexTxt.Text)].GetType() == typeof(Rect);
            if (TransRB.Checked)
            {
                Point translateVector = new Point(Int32.Parse(tVectorXTxt.Text), Int32.Parse(tVectorYTxt.Text));
                if (isCircle)
                {
                    TranslateCircle((Circle)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], translateVector, Int32.Parse(shapeIndexTxt.Text));
                }
                else if (isEllipse)
                {
                    TranslateEllipse((Ellipse)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], translateVector, Int32.Parse(shapeIndexTxt.Text));
                }
                else if (isRect)
                {
                    TranslateRect((Rect)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], translateVector, Int32.Parse(shapeIndexTxt.Text));
                }
                else
                {
                    TranslateLine(shapesHistory[Int32.Parse(shapeIndexTxt.Text)], translateVector, Int32.Parse(shapeIndexTxt.Text));
                }
            }
            else if (ScaleRB.Checked)
            {
                if (isCircle)
                {
                    ScaleCircle((Circle)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(scaleTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
                else if (isEllipse)
                {
                    ScaleEllipse((Ellipse)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(scaleTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
                else if (isRect)
                {
                    ScaleRect((Rect)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(scaleTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
                else
                {
                    ScaleLine(shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(scaleTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
            }
            else if (RotateRB.Checked)
            {
                if (isCircle)
                {
                    RotateCircle((Circle)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(rotateTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
                else if (isEllipse)
                {
                    RotateEllipse((Ellipse)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(rotateTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
                else if (isRect)
                {
                    RotateRect((Rect)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(rotateTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
                else
                {
                    RotateLine(shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(rotateTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                }
            }
            else if (shearRB.Checked)
            {
                if (isCircle)
                {
                    ShearCircle();
                }
                else if (isEllipse)
                {
                    ShearEllipse();
                }
                else if (isRect)
                {
                    if (HorizontalCB.Checked)
                    {
                        ShearRectHorizontally((Rect)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(shearTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                    }
                    if (VerticallCB.Checked)
                    {
                        ShearRectVertically((Rect)shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(shearTxt.Text), Int32.Parse(shapeIndexTxt.Text));
                    }
                }
                else
                {
                    ShearLine();
                }
            }
            else if (reflectRB.Checked)
            {
                if (HorizontalCB.Checked)
                {
                    ReflectionHorizontally(shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(shapeIndexTxt.Text));
                }
                if (VerticallCB.Checked)
                {
                    ReflectionVertically(shapesHistory[Int32.Parse(shapeIndexTxt.Text)], Int32.Parse(shapeIndexTxt.Text));
                }
            }
            highlightHistory = shapesHistory[Int32.Parse(shapeIndexTxt.Text)].points;
            HighlightPexels(shapesHistory[Int32.Parse(shapeIndexTxt.Text)].points, HIGHLIGHT_cOLOR);
            logError(shapesHistory[Int32.Parse(shapeIndexTxt.Text)].points[shapesHistory[Int32.Parse(shapeIndexTxt.Text)].points.Count - 1].ToString());
            UpdateImage();
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            IntializeImage();
            shapesHistory.Clear();
            uilog.Text = "";
            consoleError.Text = "";
            highlightHistory.Clear();
        }

        private void shapeIndexTxt_TextChanged(object sender, EventArgs e)
        {
            if (shapeIndexTxt.Text != "")
            {
                int index = Int32.Parse(shapeIndexTxt.Text);
                if (index >= shapesHistory.Count)
                {
                    logError("Invalid shape Index " + index);
                }
                else
                {
                    HighlightPexels(highlightHistory, PEN_COLOR);
                    HighlightPexels(shapesHistory[index].points, HIGHLIGHT_cOLOR);
                    highlightHistory = shapesHistory[index].points;
                    UpdateImage();
                }
            }

        }

        //basic drawing component
        public void addPexeltoFrameStack(Point pt, Color color)
        {
            if (IMAGE_HEIGHT - pt.Y > IMAGE_HEIGHT || pt.X > IMAGE_WIDTH || pt.X < 0 || IMAGE_HEIGHT - pt.Y < 0)
            {
                //log("Error pt : " + pt.X + "," + pt.Y);
                return;
            }
            //log("Point Drawn at : (" + pt.X + ", " + pt.Y + ")");
            image1.SetPixel(pt.X, IMAGE_HEIGHT - pt.Y, color);
        }
        public void UpdateImage()
        {
            pictureBox1.Image = image1;
        }
        //SHAPES DRAWING ALGORITHMS
        public Shape DDA(Point start, Point end, Color color)
        {
            Shape line = new Shape();
            int pixelVariant = 0;


            bool x1Sup = start.X > end.X;
            bool y1Sup = start.Y > end.Y;
            bool isVert = false;
            float slope;
            if (end.X - start.X != 0)
            {
                slope = ((float)end.Y - (float)start.Y) / ((float)end.X - (float)start.X);
            }
            else
            {
                isVert = true;
                slope = 0;
            }

            bool isYoct = slope > 1 || slope < -1;

            switch (x1Sup, y1Sup)
            {
                case (false, false):
                    //1st octant, 2nd octant
                    pixelVariant = 1;
                    logError("1st");
                    break;
                case (true, false):
                    //3rd octant, 4th octant
                    SwapPoints(ref start, ref end);
                    if (isYoct)
                    {
                        pixelVariant = -1;
                    }
                    else
                    {
                        pixelVariant = 1;
                    }
                    logError("2nd");
                    break;
                case (true, true):
                    //5th octant, 6th octant
                    SwapPoints(ref start, ref end);
                    pixelVariant = 1;
                    logError("3rd");
                    break;
                case (false, true):
                    //7th octant, 8th octant
                    if (isYoct)
                    {
                        pixelVariant = -1;
                    }
                    else
                    {
                        pixelVariant = 1;
                    }
                    logError("4th");
                    break;
                default:
                    logError("Something Went wrong");
                    break;
            }
            Point cur = start;



            line.Addpt(cur, IMAGE_REMAP_FACTOR);
            float walker;
            if (isYoct || isVert)
            {
                logError("Y oct");
                //2,3,6,7 octants
                float invSlope = Math.Abs(((float)end.X - (float)start.X) / ((float)end.Y - (float)start.Y));
                walker = cur.X;
                for (int i = 0; i < Math.Abs(end.Y - start.Y); i++)
                {
                    walker += invSlope;
                    if ((int)walker > cur.X)
                    {
                        cur.X = (int)walker;
                    }
                    cur.Y += pixelVariant;
                    line.Addpt(cur, IMAGE_REMAP_FACTOR);
                    addPexeltoFrameStack(cur, color);
                }
            }
            else
            {
                logError("X oct " + slope + " " + pixelVariant);
                //1,4,5,8 octants
                walker = cur.Y;
                for (int i = 0; i < Math.Abs(end.X - start.X); i++)
                {
                    if (slope > 0)
                    {
                        //1st and 8th octant
                        walker += slope;
                        if ((int)walker > cur.Y)
                        {
                            cur.Y = (int)walker;
                        }
                    }
                    else
                    {
                        //4th and 8th octant
                        walker += slope;
                        if ((int)walker < cur.Y)
                        {
                            cur.Y = (int)walker;
                        }
                    }
                    cur.X += pixelVariant;
                    line.Addpt(cur, IMAGE_REMAP_FACTOR);
                    addPexeltoFrameStack(cur, color);
                }

            }
            addPexeltoFrameStack(cur, color);
            return line;
        }
        public Shape Bresenham(Point start, Point end, Color color)
        {
            Shape line = new Shape();
            int pixelVariant = 0;


            bool x1Sup = start.X > end.X;
            bool y1Sup = start.Y > end.Y;

            float slope;
            if (end.X - start.X != 0)
            {
                slope = ((float)end.Y - (float)start.Y) / ((float)end.X - (float)start.X);
            }
            else
            {
                slope = 0;
            }

            bool isYoct = slope > 1 || slope < -1;

            switch (x1Sup, y1Sup)
            {
                case (false, false):
                    //1st octant, 2nd octant
                    pixelVariant = 1;
                    logError("1st");
                    break;
                case (true, false):
                    //3rd octant, 4th octant
                    SwapPoints(ref start, ref end);
                    pixelVariant = -1;
                    logError("2nd");
                    break;
                case (true, true):
                    //5th octant, 6th octant
                    SwapPoints(ref start, ref end);
                    pixelVariant = 1;
                    logError("3rd");
                    break;
                case (false, true):
                    //7th octant, 8th octant
                    pixelVariant = -1;
                    logError("4th");
                    break;
                default:
                    logError("Something Went wrong");
                    break;
            }
            Point cur = start;

            int dy = end.Y - start.Y;
            int dx = end.X - start.X;
            int pk = (2 * dy) - dx;

            line.Addpt(cur, IMAGE_REMAP_FACTOR);
            addPexeltoFrameStack(cur, color);
            //doctor part is only the else statement
            if (((float)dy / (float)dx) > 1)
            {
                for (int i = 0; i < dy; i++)
                {
                    cur.Y += pixelVariant;
                    if (pk > 0)
                    {
                        cur.X++;
                        pk += (2 * dx) - (2 * dy);
                    }
                    else
                    {
                        pk += (2 * dx);
                    }
                    line.Addpt(cur, IMAGE_REMAP_FACTOR);
                    addPexeltoFrameStack(cur, color);
                }
            }
            else
            {
                for (int i = 0; i < dx; i++)
                {
                    cur.X += pixelVariant;
                    if (pk > 0)
                    {
                        cur.Y++;
                        pk += (2 * dy) - (2 * dx);
                    }
                    else
                    {
                        pk += (2 * dy);
                    }
                    line.Addpt(cur, IMAGE_REMAP_FACTOR);
                    addPexeltoFrameStack(cur, color);
                }
            }
            return line;

        }
        public Ellipse DrawEllipse(Point center, int rY, int rX, Color color)
        {
            Ellipse e = new Ellipse() { center = new Point(center.X - IMAGE_REMAP_FACTOR, center.Y - IMAGE_REMAP_FACTOR), radiusX = rX, radiusY = rY };
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                Pen p = new Pen(color);
                g.DrawEllipse(p, center.X - (rX / 2), center.Y - (rY / 2), rX, rY);
                pictureBox1.Refresh();
            }
            return e;
        }
        public Circle DrawCircle(Point center, int radius, Color color)
        {
            Circle circle = new Circle();
            circle.radius = radius;
            circle.AddCenter(center, IMAGE_REMAP_FACTOR);
            Point cur = new Point(0, radius);
            //drawPexel(new Point(cur.X + center.X, cur.Y + center.Y), Color.Black);
            List<Point> pts = new List<Point>();
            int pk = 1 - radius;
            while (cur.Y + 1 > cur.X)
            {
                //draw octants
                int x = cur.X;
                int y = cur.Y;
                pts.Add(new Point(x, y));
                pts.Add(new Point(y, x));
                pts.Add(new Point(y, -x));
                pts.Add(new Point(x, -y));
                pts.Add(new Point(-x, y));
                pts.Add(new Point(-y, x));
                pts.Add(new Point(-y, -x));
                pts.Add(new Point(-x, -y));
                //move point
                cur.X++;
                if (pk < 0)
                {
                    pk += ((2 * cur.X) + 1);
                }
                else
                {
                    cur.Y--;
                    pk += ((2 * cur.X) + 1 - (2 * cur.Y));
                }
            }
            for (int i = 0; i < pts.Count; i++)
            {
                Point temp = new Point((pts[i].X + center.X), (pts[i].Y + center.Y));
                circle.Addpt(temp, IMAGE_REMAP_FACTOR);
                addPexeltoFrameStack(temp, color);
            }
            return circle;
        }
        public Rect DrawRect(Point center, int l, int w, Color color)
        {
            Point startCorner = new Point((center.X - (w / 2)), (center.Y - (l / 2)));
            Rect rect = new Rect();
            rect.length = l;
            rect.width = w;
            rect.startCorner = startCorner;
            Shape line = new Shape();
            line = DDA(startCorner, new Point(startCorner.X, startCorner.Y + l), color);
            rect.points.AddRange(line.points);
            line = DDA(startCorner, new Point(startCorner.X + w, startCorner.Y), color);
            rect.points.AddRange(line.points);
            line = DDA(new Point(startCorner.X, startCorner.Y + l), new Point(startCorner.X + w, startCorner.Y + l), color);
            rect.points.AddRange(line.points);
            line = DDA(new Point(startCorner.X + w, startCorner.Y), new Point(startCorner.X + w, startCorner.Y + l), color);
            rect.points.AddRange(line.points);
            return rect;
        }
        //TRANSFORM ALGORITHMS
        //translate
        public void TranslateLine(Shape line, Point translateVector, int shapeIndex)
        {
            Point newStart = new Point(line.points[0].X + translateVector.X + IMAGE_REMAP_FACTOR, line.points[0].Y + translateVector.Y + IMAGE_REMAP_FACTOR);
            Point newEnd = new Point(line.points[line.points.Count - 1].X + translateVector.X + IMAGE_REMAP_FACTOR, line.points[line.points.Count - 1].Y + translateVector.Y + IMAGE_REMAP_FACTOR);
            Shape l = DDA(newStart, newEnd, PEN_COLOR);
            shapesHistory[shapeIndex].points.Clear();
            shapesHistory[shapeIndex].points.AddRange(l.points);
            ErasePexels(line.points);
        }
        public void TranslateCircle(Circle circle, Point translateVector, int shapeIndex)
        {
            Point newCenter = new Point(circle.center.X + translateVector.X + IMAGE_REMAP_FACTOR, circle.center.Y + translateVector.Y + IMAGE_REMAP_FACTOR);
            shapesHistory[shapeIndex] = null;
            shapesHistory[shapeIndex] = DrawCircle(newCenter, circle.radius, PEN_COLOR);
            ErasePexels(circle.points);
        }
        public void TranslateEllipse(Ellipse ellipse, Point translateVector, int shapeIndex)
        {
            DrawEllipse(new Point(ellipse.center.X + IMAGE_REMAP_FACTOR, ellipse.center.Y + IMAGE_REMAP_FACTOR), ellipse.radiusY, ellipse.radiusX, BACKGROUND_COLOR);
            Point newCenter = new Point(ellipse.center.X + translateVector.X + IMAGE_REMAP_FACTOR, ellipse.center.Y + translateVector.Y + IMAGE_REMAP_FACTOR);
            shapesHistory[shapeIndex] = null;
            shapesHistory[shapeIndex] = DrawEllipse(newCenter, ellipse.radiusY, ellipse.radiusX, PEN_COLOR);
        }
        public void TranslateRect(Rect rect, Point translateVector, int shapeIndex)
        {
            Point newCenter = new Point(rect.startCorner.X + (rect.width / 2) + translateVector.X + IMAGE_REMAP_FACTOR, rect.startCorner.Y + (rect.length / 2) + translateVector.Y + IMAGE_REMAP_FACTOR);
            shapesHistory[shapeIndex] = null;
            shapesHistory[shapeIndex] = DrawRect(newCenter, rect.length, rect.width, PEN_COLOR);
            ErasePexels(rect.points);
        }
        //scale
        public void ScaleLine(Shape line, int scaleFactor, int shapeIndex)
        {
            logError("Cant Scale a line");
        }
        public void ScaleCircle(Circle circle, int scaleFactor, int shapeIndex)
        {
            shapesHistory[shapeIndex] = DrawCircle(new Point(circle.center.X + IMAGE_REMAP_FACTOR, circle.center.Y + IMAGE_REMAP_FACTOR), circle.radius * scaleFactor, PEN_COLOR);
            ErasePexels(circle.points);
        }
        public void ScaleEllipse(Ellipse ellipse, int scaleFactor, int shapeIndex)
        {
            Point c = new Point(ellipse.center.X + IMAGE_REMAP_FACTOR, ellipse.center.Y + IMAGE_REMAP_FACTOR);
            DrawEllipse(c, ellipse.radiusY, ellipse.radiusX, BACKGROUND_COLOR);
            shapesHistory[shapeIndex] = null;
            shapesHistory[shapeIndex] = DrawEllipse(c, ellipse.radiusY * scaleFactor, ellipse.radiusX * scaleFactor, PEN_COLOR);
        }
        public void ScaleRect(Rect rect, int scaleFactor, int shapeIndex)
        {
            Point newCenter = new Point(rect.startCorner.X + (rect.width / 2) + IMAGE_REMAP_FACTOR, rect.startCorner.Y + (rect.length / 2) + IMAGE_REMAP_FACTOR);
            shapesHistory[shapeIndex] = null;
            shapesHistory[shapeIndex] = DrawRect(newCenter, rect.length, rect.width, PEN_COLOR);
            ErasePexels(rect.points);
        }
        //rotation
        public void RotateLine(Shape line, int rotation, int shapeIndex)
        {
            Point endPt = line.points[line.points.Count - 1];
            int x = endPt.X * (int)Math.Cos(rotation) - endPt.Y * (int)Math.Sin(rotation);
            int y = endPt.X * (int)Math.Sin(rotation) - endPt.Y * (int)Math.Cos(rotation);
            Point newEnd = new Point(x, y);
            ErasePexels(line.points);
            shapesHistory[shapeIndex] = DDA(new Point(line.points[0].X + IMAGE_REMAP_FACTOR, line.points[0].Y + IMAGE_REMAP_FACTOR), new Point(endPt.X + IMAGE_REMAP_FACTOR, endPt.Y + IMAGE_REMAP_FACTOR), PEN_COLOR);
        }
        public void RotateCircle(Circle circle, int rotation, int shapeIndex)
        {
            logError("Circles Cant Be Rotated");
        }
        public void RotateEllipse(Ellipse ellipse, int rotation, int shapeIndex)
        {
            DrawEllipse(new Point(ellipse.center.X + IMAGE_REMAP_FACTOR, ellipse.center.Y + IMAGE_REMAP_FACTOR), ellipse.radiusY, ellipse.radiusX, BACKGROUND_COLOR);
            //logError("Ellipses Cant Be Rotated");
            Matrix matrix = new Matrix();
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                Pen p = new Pen(PEN_COLOR);
                matrix.RotateAt(rotation, new Point(ellipse.center.X + IMAGE_REMAP_FACTOR - (ellipse.radiusX / 2), ellipse.center.Y + IMAGE_REMAP_FACTOR - (ellipse.radiusY / 2)));
                g.Transform = matrix;
                Rectangle r = new Rectangle(ellipse.center.X + IMAGE_REMAP_FACTOR - (ellipse.radiusX / 2), ellipse.center.Y + IMAGE_REMAP_FACTOR - (ellipse.radiusY / 2), ellipse.radiusX, ellipse.radiusY);
                g.DrawEllipse(p, r);
                pictureBox1.Refresh();
            }

        }
        public void RotateRect(Rect rect, int rotation, int shapeIndex)
        {
            ErasePexels(rect.points);
            Shape line = new Shape();
            Point botLeft = rect.startCorner;
            Point botRight = new Point(botLeft.X + rect.width * (int)Math.Cos(rotation) - botLeft.Y * (int)Math.Sin(rotation), botLeft.X + rect.width * (int)Math.Sin(rotation) - botLeft.Y * (int)Math.Cos(rotation));
            Point topLeft = new Point(botLeft.X * (int)Math.Cos(rotation) - botLeft.Y + rect.length * (int)Math.Sin(rotation), botLeft.X * (int)Math.Sin(rotation) - botLeft.Y + rect.length * (int)Math.Cos(rotation));
            Point topRight = new Point(botLeft.X + rect.width * (int)Math.Cos(rotation) - botLeft.Y + rect.length * (int)Math.Sin(rotation), botLeft.X + rect.width * (int)Math.Sin(rotation) - botLeft.Y + rect.length * (int)Math.Cos(rotation));

            line = DDA(botLeft, botRight, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(botLeft, topLeft, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(topLeft, topRight, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(botRight, topRight, PEN_COLOR);
            rect.points.AddRange(line.points);
        }
        //shearing
        public void ShearLine() { logError("Cant Shear Line"); }
        public void ShearCircle() { logError("Cant Shear Circle"); }
        public void ShearEllipse() { logError("Cant Shear Ellipse"); }
        public void ShearRectVertically(Rect rect, int shearAmount, int shapeIndex)
        {
            ErasePexels(rect.points);
            Shape line = new Shape();
            Point botLeft = rect.startCorner;
            Point botRight = new Point(botLeft.X + rect.width, botLeft.Y + shearAmount);

            Point topLeft = new Point(botLeft.X, botLeft.Y + rect.length);
            Point topRight = new Point(botLeft.X + rect.width, botLeft.Y + rect.length + shearAmount);

            line = DDA(botLeft, botRight, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(botLeft, topLeft, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(topLeft, topRight, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(botRight, topRight, PEN_COLOR);
            rect.points.AddRange(line.points);
        }
        public void ShearRectHorizontally(Rect rect, int shearAmount, int shapeIndex)
        {
            ErasePexels(rect.points);
            Shape line = new Shape();
            Point botLeft = rect.startCorner;
            Point botRight = new Point(botLeft.X + rect.width, botLeft.Y);

            Point topLeft = new Point(botLeft.X + shearAmount, botLeft.Y + rect.length);
            Point topRight = new Point(botLeft.X + shearAmount + rect.width, botLeft.Y + rect.length);

            line = DDA(botLeft, botRight, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(botLeft, topLeft, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(topLeft, topRight, PEN_COLOR);
            rect.points.AddRange(line.points);
            line = DDA(botRight, topRight, PEN_COLOR);
            rect.points.AddRange(line.points);
        }
        //reflection
        public void ReflectionVertically(Shape s, int shapeIndex)
        {
            List<Point> pts = new List<Point>();
            pts.AddRange(s.points);
            ErasePexels(s.points);
            s.points.Clear();
            for (int i = 0; i < pts.Count; i++)
            {
                Point p = new Point(-pts[i].X, pts[i].Y);
                addPexeltoFrameStack(new Point(p.X + IMAGE_REMAP_FACTOR, p.Y + IMAGE_REMAP_FACTOR), PEN_COLOR);
                s.points.Add(p);
            }
            shapesHistory[shapeIndex] = s;
        }
        public void ReflectionHorizontally(Shape s,int shapeIndex)
        {
            List<Point> pts = new List<Point>();
            pts.AddRange(s.points);
            ErasePexels(s.points);
            s.points.Clear();
            for (int i = 0; i < pts.Count; i++)
            {
                Point p = new Point(pts[i].X, -pts[i].Y);
                addPexeltoFrameStack(new Point(p.X + IMAGE_REMAP_FACTOR, p.Y + IMAGE_REMAP_FACTOR), PEN_COLOR);
                s.points.Add(p);
            }
            shapesHistory[shapeIndex] = s;
        }
        //HELPING FUNCTIONS
        public void log(String s)
        {
            uilog.Text += s + Environment.NewLine;
        }
        public void logError(String s)
        {
            consoleError.Text += s + Environment.NewLine;
        }
        public bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public void LineThickness(Point pt)
        {
            addPexeltoFrameStack(new Point(pt.X - 1, pt.Y), Color.Black);
            addPexeltoFrameStack(new Point(pt.X + 1, pt.Y), Color.Black);
        }
        public void SwapPoints(ref Point p1, ref Point p2)
        {
            Point Temp = new Point(p1.X, p1.Y);
            p1 = new Point(p2.X, p2.Y);
            p2 = new Point(Temp.X, Temp.Y);
        }
        //highlight helper functions
        public void ErasePexels(List<Point> points)
        {
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].X + IMAGE_REMAP_FACTOR % 25 == 0 || points[i].Y + IMAGE_REMAP_FACTOR % 25 == 0)
                {
                    addPexeltoFrameStack(new Point(points[i].X + IMAGE_REMAP_FACTOR, points[i].Y + IMAGE_REMAP_FACTOR), SECONDARY_COLOR);
                }
                else
                {
                    addPexeltoFrameStack(new Point(points[i].X + IMAGE_REMAP_FACTOR, points[i].Y + IMAGE_REMAP_FACTOR), BACKGROUND_COLOR);
                }

            }
        }
        public void HighlightPexels(List<Point> points, Color color)
        {
            for (int i = 0; i < points.Count; i++)
            {
                addPexeltoFrameStack(new Point(points[i].X + IMAGE_REMAP_FACTOR, points[i].Y + IMAGE_REMAP_FACTOR), color);
            }
        }
    }
    public partial class Shape
    {
        public List<Point> points = new List<Point>();
        public void Addpt(Point pt, int mapFactor)
        {
            this.points.Add(new Point(pt.X - mapFactor, pt.Y - mapFactor));
        }
    }
    public partial class Circle : Shape
    {
        public Point center = new Point();
        public int radius = new int();
        public void AddCenter(Point pt, int mapFactor)
        {
            this.center = (new Point(pt.X - mapFactor, pt.Y - mapFactor));
        }
    }
    public partial class Ellipse : Shape
    {
        public Point center = new Point();
        public int radiusY = new int();
        public int radiusX = new int();
        public void AddCenter(Point pt, int mapFactor)
        {
            this.center = (new Point(pt.X - mapFactor, pt.Y - mapFactor));
        }
    }
    public partial class Rect : Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        public Point startCorner { get; set; }
    }

}
