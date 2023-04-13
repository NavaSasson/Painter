using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using System.Timers;


namespace Drawing
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false, isMouseDown = false, isMoving = false, isAnimation = false, moving_bool = false;
        Point pStart, pEnd, mouse_down_point, animation_point;
        Pen p = new Pen(Color.Black, 6);
        Pen Eraser = new Pen(Color.White, 15);
        int index ,shape_to_move_index = -1, animation_move_x, animation_move_y, animationflag = 0;
        //ColorDialog cd = new ColorDialog();


        ShapesList shape_list = new ShapesList();

        Shape temp, clicked_inside, shape_to_move, shape_to_animate, animation_shape;

        private static System.Timers.Timer aTimer;



        public Form1()
        {
            InitializeComponent();
            
            bm = new Bitmap(canvasPic.Width, canvasPic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            canvasPic.Image = bm;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }


        private void canvasPic_MouseClick(object sender, MouseEventArgs e)
        {
            gbAnimate.Visible = true;
            btnBottomAnimate.Visible = true;
            btnLeftAnimate.Visible = true;
            btnRightAnimate.Visible = true;
            btnTopAnimate.Visible = true;




            for (int i = shape_list.NextIndex - 1; i >= 0; i--)
            {
                if (shape_list[i].isInside(e.X, e.Y))
                {
                    clicked_inside = shape_list[i];
                    break;
                }
            }


            if (clicked_inside != null)
            {
                // Fill
                if (index == 7)
                {
                    Point point = set_Point(canvasPic, e.Location);
                    Fill(bm, point.X, point.Y, p.Color);
                    // sets the fill color 
                    clicked_inside.setColorFill(p.Color);
                }


                if (index == 8 && (!isMoving))
                {
                    for (int i = shape_list.NextIndex - 1; i >= 0; i--)
                    {
                        if (shape_list[i].isInside(e.X, e.Y))
                        {
                            shape_to_move = shape_list[i];
                            shape_to_move_index = i;
                            if (shape_to_move != null && shape_to_move_index == i)
                                moving_bool = true;
                            break;
                        }
                    }
                }

                // Delete Shape
                if (index == 9)
                {
                    for (int i = shape_list.NextIndex - 1; i >= 0; i--)
                    {
                        if (shape_list[i].isInside(e.X, e.Y))
                        {
                            shape_list[i].setColorFill(Color.White);
                            shape_list[i].setColorAround(Color.White);
                            shape_list.Remove(i);
                            g.Clear(Color.White);
                            canvasPic.Image = bm;
                            DrawAll(g);
                            break;
                        }
                    }
                }


                // change colorAround
                if (index == 10)
                {
                    for (int i = shape_list.NextIndex - 1; i >= 0; i--)
                    {
                        if (shape_list[i].isInside(e.X, e.Y))
                        {
                            shape_list[i].Draw(g);
                            shape_list[i].setColorAround(p.Color);
                            break;
                        }
                    }
                }

                if (index == 11 || index == 12 || index == 13 || index == 14)
                {
                    for (int i = shape_list.NextIndex - 1; i >= 0; i--)
                    {
                        if (shape_list[i].isInside(e.X, e.Y))
                        {
                            shape_to_animate = shape_list[i];
                            break;
                        }
                    }
                }

                if (index == 15)
                {
                    // set animation shape
                    if (animationflag == 0)
                    {
                        for (int i = shape_list.NextIndex - 1; i >= 0; i--)
                        {
                            if (shape_list[i].isInside(e.X, e.Y))
                            {
                                animation_shape = shape_list[i];
                                animationflag = 1;
                                Choose_end_point.Visible = true;
                                Choose_an_object.Visible = false;
                                break;
                            }
                        }
                    }

                    // set end animation point
                    if (animationflag == 1)
                    {

                        animation_point = Cursor.Position;
                        
                        animation_move_x = (animation_shape.P1.X - animation_point.X)/5;
                        animation_move_y = (animation_shape.P1.Y - animation_point.Y)/5;
                        timer1.Start();
                        animationflag = 0;
                    }

                   

                    
                    Choose_end_point.Visible = false;
                }
               
            }
        }
 
   

        private void canvasPic_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            paint = true;
            mouse_down_point = e.Location;
            // sets the start point (=P1)
            pStart = e.Location;
        }

        private void canvasPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                // Pen
                if (index == 1)
                {
                    pEnd = e.Location;
                    g.DrawLine(p, pStart, pEnd);
                    pStart = pEnd;
                }

                // Eraser
                if (index == 2)
                {
                    pEnd = e.Location;
                    g.DrawLine(Eraser, pStart, pEnd);
                    pStart = pEnd;
                }
            }

            // Move shape
            if (isMouseDown && index == 8)
            {
                isMoving = true;
               
                
                if (moving_bool)
                {
                    shape_to_move.set_Location(e.Location);
                    g.Clear(Color.White);
                    canvasPic.Image = bm;
                    DrawAll(g);
                }
               
            }

            pEnd = e.Location;
            isMoving = false;
            canvasPic.Refresh();
        }

        private void canvasPic_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            paint = false;
            pEnd = e.Location;

            double scope, area;

            // Draw Circle
            if (index == 3)
            {
                temp = new myCircle(pStart, pEnd, p.Color, p.Width);
                shape_list[shape_list.NextIndex] = temp;
                temp.Draw(g);
            }

            // Draw Rectangle
            if (index == 4)
            {
                temp = new myRectangle(pStart, pEnd, p.Color, p.Width);
                shape_list[shape_list.NextIndex] = temp;
                temp.Draw(g);
            }

            // Draw Line
            if (index == 5)
            {
                temp = new myLine(pStart, pEnd, p.Color, p.Width);
                shape_list[shape_list.NextIndex] = temp;
                temp.Draw(g);
            }

            // Draw Square
            if (index == 6)
            {
                temp = new mySquare(pStart, pEnd, p.Color, p.Width);
                shape_list[shape_list.NextIndex] = temp;
                temp.Draw(g);
            }


            if (index >= 3 && index <= 6)
            {
                scope = temp.Scope();
                area = temp.Area();
                lbScope.Text = "Scope = " + scope.ToString();
                lbArea.Text = "Area = " + area.ToString();
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnRectan_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void btnPenThickness_Click(object sender, EventArgs e)
        {
            index = 0;
            tbPenThickness.Visible = true;
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbPenThickness.Text != "Pen size...")
            {
                // convert string from textBox to float
                p.Width = float.Parse(tbPenThickness.Text, CultureInfo.InvariantCulture.NumberFormat);
                tbPenThickness.Visible = false;
            }

            if (tbPenThickness.Visible == false)
                btnOK.Visible = false;
        }
    
        private void btnFill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            index = 8;
            Choose_an_object.Visible = true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            index = 9;
        }


        // Running all the time and drawing the form
        private void canvasPic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; ;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.X - pStart.X);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.Y - pStart.Y);
                }
                if (index == 5)
                {
                    g.DrawLine(p, pStart.X, pStart.Y, pEnd.X, pEnd.Y);
                }
                if (index == 6)
                {
                    g.DrawRectangle(p, pStart.X, pStart.Y, pEnd.X - pStart.X, pEnd.X - pStart.X);
                }

                if (index == 9)
                {
                    canvasPic.Invalidate();
                    DrawAll(g);
                    canvasPic.Refresh();
                }
            }
        }

        public void DrawAll(Graphics g)
        {

            for (int i = 0; i < shape_list.NextIndex; i++)
            {
                shape_list[i].Draw(g);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point help = new Point();
            if (animation_point.X == animation_shape.P1.X && animation_point.Y == animation_shape.P1.Y)
                return;
            help.X = animation_move_x + animation_shape.P1.X;
            help.Y = animation_move_y + animation_shape.P1.Y;
            animation_shape.set_Location(help);
            g.Clear(Color.White);
            DrawAll(g);
            //timer1.Stop();
            //timer1.Dispose();
        }

        private void btnTopAnimate_Click(object sender, EventArgs e)
        {
            index = 11;
            Point help = new Point();
            if (shape_to_animate != null)
            {
                help.X = shape_to_animate.P1.X;
                help.Y = shape_to_animate.P1.Y - 10;
                shape_to_animate.set_Location(help);
                g.Clear(Color.White);
                canvasPic.Image = bm;
                DrawAll(g);
            }
        }

        private void btnBottomAnimate_Click(object sender, EventArgs e)
        {
            index = 12;
            Point help = new Point();
            if (shape_to_animate != null)
            {
                help.X = shape_to_animate.P1.X;
                help.Y = shape_to_animate.P1.Y + 10;
                shape_to_animate.set_Location(help);
                g.Clear(Color.White);
                canvasPic.Image = bm;
                DrawAll(g);
            }
        }

        private void btnLeftAnimate_Click(object sender, EventArgs e)
        {
            index = 13;
            Point help = new Point();
            if (shape_to_animate != null)
            {
                help.X = shape_to_animate.P1.X - 10;
                help.Y = shape_to_animate.P1.Y;
                shape_to_animate.set_Location(help);
                g.Clear(Color.White);
                canvasPic.Image = bm;
                DrawAll(g);
            }
        }

        private void btnAnimate_Click(object sender, EventArgs e)
        {
            index = 15;
        }

        
        

        private void btnRightAnimate_Click(object sender, EventArgs e)
        {
            index = 14;
            Point help = new Point();
            if (shape_to_animate != null)
            {
                help.X = shape_to_animate.P1.X + 10;
                help.Y = shape_to_animate.P1.Y;
                shape_to_animate.set_Location(help);
                g.Clear(Color.White);
                canvasPic.Image = bm;
                DrawAll(g);
            }
        }


        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            index = 0;
            DialogResult colorResult = colorDialog1.ShowDialog();
            if (colorResult == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;
                p.Color = colorDialog1.Color;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            index = 10;
        }

  
        private void btnClear_Click(object sender, EventArgs e)
        {
            index = 0;
            g.Clear(Color.White);
            lbScope.Text = "Scope = ";
            lbArea.Text = "Area = ";
            canvasPic.Image = bm;
            index = 0;
            Choose_an_object.Visible = false;

            gbAnimate.Visible = false;
            btnBottomAnimate.Visible = false;
            btnLeftAnimate.Visible = false;
            btnRightAnimate.Visible = false;
            btnTopAnimate.Visible = false;

            shape_list.RemoveAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // SaveFileDialog is a windows popup screen for file saving 
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // GetCurrentDirectory - takes all saving path
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "paints files(*.Drawing)| *.Drawing | All files(*.*) | *.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) // opens save dialog if clicked ok
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                // stream for file name
                {
                    // the actual saving
                    formatter.Serialize(stream, shape_list);
                    MessageBox.Show("The filed has been saved");
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Shape> b;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "paints files(*.Drawing)| *.Drawing | All files(*.*) | *.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                shape_list = (ShapesList)binaryFormatter.Deserialize(stream);
                DrawAll(g);
            }
        }


        static Point set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }

        // בדיקת הצבע של כל פיקסל לפני המילוי
        private void Validate(Bitmap bm, Stack<Point> stack_point, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                stack_point.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        // the func gets the old pixel color and fill new color from the clicked point till the stack count > 0 
        public void Fill(Bitmap bm, int x, int y, Color New_Clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_Clr);
            if (Old_Color == New_Clr) { return; } // We dont need to fill, its already in the New_Clr

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_Clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_Clr);
                }
            }
        }
    }
}