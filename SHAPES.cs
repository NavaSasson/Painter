using System.Drawing;

namespace Drawing
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Windows.Forms;

    [Serializable] // All objects are saved, save in binary file outside the program
    // Don't passes to children
    public abstract class Shape
    {
        //private by default
        Point p1;
        Point p2;
        Color colorFill = Color.Transparent;
        Color colorAround;
        float penThickness;

        public Shape()
        { }



        public Point P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
            }
        }

        public Point P2
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
            }
        }

        public Color color_fill
        {
            get
            {
                return colorFill;
            }
            set
            {
                colorFill = value;
            }
        }

        public void setColorFill(Color color)
        {
            this.colorFill = color;
        }

        public void setColorAround(Color color)
        {
            this.colorAround = color;
        }

        public Color color_around
        {
            get
            {
                return colorAround;
            }
            set
            {
                colorAround = value;
            }
        }

        public float pen_tickness
        {
            get
            {
                return penThickness;
            }
            set
            {
                penThickness = value;
            }
        }

        public abstract void Draw(Graphics g);
        public abstract void set_Location(Point p);
        public abstract double Scope();
        public abstract double Area();
        public abstract bool isInside(int xP, int yP);
    }


    //---------------------------------------------------------------------------------------------//

    [Serializable]
    public class myLine : Shape
    {

        public myLine()
        { }
        public myLine(Point p1, Point p2, Color color, float penThickness)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.color_around = color;
            this.pen_tickness = penThickness;
        }
        public override double Scope()
        {
            double dis = Math.Pow(P1.X - P2.X, 2);
            dis += Math.Pow(P1.Y - P2.Y, 2);
            dis = Math.Sqrt(dis);
            return Math.Abs(dis);
        }

        public override double Area()
        {
            return 0;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color_around, pen_tickness);
            g.DrawLine(pen, P1.X, P1.Y, P2.X, P2.Y);
        }

        public override void set_Location(Point p)
        {
            Point help = new Point();
            help.X = (int)(p.X + P2.X - P1.X);
            help.Y = (int)(p.Y + P2.Y - P1.Y);
            this.P1 = p;
            this.P2 = help;
        }
        public override bool isInside(int x, int y)
        {
            if ((P1.X - x) != 0 && (P1.X - P2.X) != 0)
            {
                double originalm = (P1.Y - P2.Y) / (P1.X - P2.X);// שיפוע הישר
                double curm = (P1.Y - y) / (P1.X - x); // שיעו בין P1 לנקודה שלחצו בה
                // שיפוע חיובי
                if (originalm >= 0 && originalm == curm && x >= P1.X && x <= P2.X && y >= P1.Y && y <= P2.Y)
                    return true;
                // שיפוע שלילי
                if (originalm < 0 && originalm == curm && x <= P1.X && x >= P2.X && y >= P1.Y && y <= P2.Y)
                    return true;
            }
            return false;
        }
    }

//---------------------------------------------------------------------------------------//
    [Serializable]
    public class myRectangle : Shape
    {

        public myRectangle()
        { }
        public myRectangle(Point p1, Point p2, Color color, float penThickness)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.color_around = color;
            this.pen_tickness = penThickness;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color_around, pen_tickness);
            g.DrawRectangle(pen, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y);
            Brush b = new SolidBrush(this.color_fill);
            g.FillRectangle(b, P1.X, P1.Y, P2.X - P1.X, P2.Y - P1.Y);
        }

        public override void set_Location(Point p)
        {
            Point help = new Point();
            help.X = (int)(p.X + P2.X - P1.X);
            help.Y = (int)(p.Y + P2.Y - P1.Y);
            this.P1 = p;
            this.P2 = help;
        }

        public override double Scope()
        {
            return 2 * (P2.X - P1.X) + 2 * (P2.Y - P1.Y);
        }

        public override double Area()
        {
            return (P2.X - P1.X) * (P2.Y - P1.Y);
        }
        public override bool isInside(int x, int y)
        {
            if (x >= P1.X && x <= P2.X && y >= P1.Y && y <= P2.Y)
                return true;
            return false;
        }

        ~myRectangle() { }
    }
    //---------------------------------------------------------------------------------------------//

    [Serializable]
    public class mySquare : myRectangle
    {
        public mySquare()
        { }
        public mySquare(Point p1, Point p2, Color color, float penThickness)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.color_around = color;
            this.pen_tickness = penThickness;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color_around, pen_tickness);
            g.DrawRectangle(pen, P1.X, P1.Y, P2.X - P1.X, P2.X - P1.X);
            Brush b = new SolidBrush(this.color_fill);
            g.FillRectangle(b, P1.X, P1.Y, P2.X - P1.X, P2.X - P1.X);
        }

        public override void set_Location(Point p)
        {
            Point help = new Point();
            help.X = (int)(p.X + P2.X - P1.X);
            help.Y = help.X;
            this.P1 = p;
            this.P2 = help;
        }
        public override double Scope()
        {
            return 4 * (P2.X - P1.X);
        }
        public override double Area()
        {
            return (P2.X - P1.X) * (P2.X - P1.X);
        }

        public override bool isInside(int x, int y)
        {
            if (x >= P1.X && x <= P2.X && y >= P1.Y && y <= P2.Y)
                return true;
            return false;
        }
    }

    //---------------------------------------------------------------------------------------------//

    [Serializable]
    public class myCircle : myRectangle
    {
        //private
        float radius;
        Point center;

        public myCircle()
        { }


        public myCircle(Point p1, Point p2, Color color, float penThickness)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.color_around = color;
            this.pen_tickness = penThickness;
            this.radius = Math.Abs(P2.X - P1.X) / 2;
            this.center.X = (P1.X + P2.X) / 2;
            this.center.Y = (P1.Y + P2.Y) / 2;
        }


        public float Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Point Center
        {
            get
            {
                return center;
            }
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color_around, pen_tickness);
            g.DrawEllipse(pen, P1.X, P1.Y, P2.X - P1.X, P2.X - P1.X);
            Brush b = new SolidBrush(this.color_fill);
            g.FillEllipse(b, P1.X, P1.Y, P2.X - P1.X, P2.X - P1.X);
        }

        public override double Scope()
        {
            return 2 * 3.14 * radius;
        }
        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        public override void set_Location(Point p)
        {
            Point help = new Point();
            help.X = (int)(p.X + P2.X - P1.X);
            help.Y = help.X;
            this.P1 = p;
            this.P2 = help;
        }
        public override bool isInside(int x, int y)
        {
            return Math.Sqrt((center.X - x) * (center.X - x) + (center.Y - y) * (center.Y - y)) < radius;
        }

        ~myCircle() { }

    }



    //---------------------------------------------------------------------------------------------//


    [Serializable]

    public class ShapesList
    {
        protected SortedList shapes;

        public ShapesList()
        {
            shapes = new SortedList();
        }
        public int NextIndex
        {
            get
            {
                return shapes.Count;
            }
            // !! there is no set !!
        }
        public Shape this[int index]
        {
            get
            {
                if (index >= shapes.Count)
                    return (Shape)null;
                //SortedList internal method
                return (Shape)shapes.GetByIndex(index);
            }
            set
            {
                if (index <= shapes.Count)
                    shapes[index] = value;
            }
        }

        public void Remove(Shape shape_to_remove)
        {
            for (int i = shapes.Count - 1; i >= 0; i--)
            {
                if (shapes[i] == shape_to_remove)
                    shapes[i] = shapes[i + 1];
                shapes.RemoveAt(shapes.Count - 1);
            }
        }

        public void Remove(int index_to_remove)
        {
            if (index_to_remove >= 0 && index_to_remove < shapes.Count)
            {

                for (int i = index_to_remove; i < shapes.Count; i++)
                {
                    shapes[i] = shapes[i + 1];
                }
                shapes.RemoveAt(shapes.Count - 1);
            }
        }

        public void RemoveAll()
        {
            shapes.Clear();
        }


        public Shape clicked_inside_shape(int clickedX, int clickedY)
        {
            Shape s;
            //for (int i = shapes.Count - 1; i >= 0; i--)
            for (int i = 0; i < shapes.Count; i++)
            {
                ((Shape)shapes[i]).isInside(clickedX, clickedY);
                s = (Shape)shapes[i];
                return s;
            }
            return null;
        }


        public int clicked_inside_index(int clickedX, int clickedY)
        {
            int i;
            for (i = shapes.Count - 1; i >= 0; i--)
            {
                ((Shape)shapes[i]).isInside(clickedX, clickedY);
                return i;
            }
            return -1;
        }
    }
}


