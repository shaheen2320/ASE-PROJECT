using System.Drawing;
using System.Windows.Forms;

//Creating a public parser class
public class Draw_Parser_class
{
    private PictureBox picture_box;

    private Point pen_startpoint;
    private Cursor cursor;
    private bool draw;


    public Draw_Parser_class(PictureBox pictureBox)
    {
        this.picture_box = pictureBox;
        this.pen_startpoint = new Point(0, 0);
        this.cursor = Cursors.Default;
        draw = false;
    }

    //creating method for drawing different shapes
    public void drawing_Commands(string command)
    {

        if (command.StartsWith("draw rectangle ")) //drawing a rectangle on Picturebox
        {

            string[] parameters = command.Split(' ');
            int x = int.Parse(parameters[2]);
            int y = int.Parse(parameters[3]);
            int width = int.Parse(parameters[4]);
            int height = int.Parse(parameters[5]);
            {

                using (Graphics g = picture_box.CreateGraphics())
                {
                    g.DrawRectangle(Pens.Black, x, y, width, height);
                }
            }
        }
        else if (command.StartsWith("draw circle ")) ////drawing a circle on Picturebox
        {

            string[] parameters = command.Split(' ');
            int coordinateX = int.Parse(parameters[2]);
            int coordinateY = int.Parse(parameters[3]);
            int radius = int.Parse(parameters[4]);
            {

                using (Graphics g = picture_box.CreateGraphics())
                {
                    g.DrawEllipse(Pens.Black, coordinateX - radius, coordinateY - radius, 2 * radius, 2 * radius);
                }
            }
        }
        else if (command.StartsWith("draw line")) //drawing a line on Picturebox
        {

            string[] parameters = command.Split(' ');
            int pointA = int.Parse(parameters[2]);
            int pointB = int.Parse(parameters[3]);
            pen_startpoint = new Point(pointA, pointB);
            {
                using (Graphics g = picture_box.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, pen_startpoint, new Point(0, 0));
                }
            }
        }
        else if (command.StartsWith("draw triangle")) //drawing a triangle on Picturebox
        {

            string[] parameters = command.Split(' ');
            int p1 = int.Parse(parameters[2]);
            int q1 = int.Parse(parameters[3]);
            int p2 = int.Parse(parameters[4]);
            int q2 = int.Parse(parameters[5]);
            int p3 = int.Parse(parameters[6]);
            int q3 = int.Parse(parameters[7]);
            using (Graphics g = picture_box.CreateGraphics())
            {
                Point[] trianglePoints = new Point[]
                {
                         new Point(p1, q1),
                         new Point(p2, q2),
                         new Point(p3, q3)
                };
                g.DrawPolygon(Pens.Black, trianglePoints);
            }
        }
        else if (command.StartsWith("cursor set "))
        {
            // Setting different type of cursors
            string[] parameters = command.Split(' ');
            if (parameters.Length > 2)
            {
                string cursor_type = parameters[2].ToLower();


                switch (cursor_type)
                {
                    case "default type":
                        cursor = Cursors.Default;
                        break;
                    case "cross":
                        cursor = Cursors.Cross;
                        break;
                    case "hand":
                        cursor = Cursors.Hand;
                        break;

                    case "pen":
                        cursor = Cursors.PanNW;
                        break;


                    default:
                        cursor = Cursors.Default;
                        break;
                }

                // Sets cursor on picturebox
                picture_box.Cursor = cursor;
            }
        }
        else if (command.StartsWith("clear surface"))
        {
            ClearDrawingSurface();

        }
        else if (command.StartsWith("cursor move ")) //This method Moves cursor to the set position
        {

            string[] parameters = command.Split(' ');
            if (parameters.Length > 3)
            {
                int a = int.Parse(parameters[2]);
                int b = int.Parse(parameters[3]);


                MoveCursor(a, b);
            }
        }
        else if (command.StartsWith("random draw")) // can draw using cursor
        {

            EnableDrawingCursor();
        }



    }
    void ClearDrawingSurface() // Clear the picturebox
    {

        picture_box.Invalidate();
    }
    private void MoveCursor(int a, int b)
    {

        Cursor.Position = picture_box.PointToScreen(new Point(a, b));
    }
    private void EnableDrawingCursor()
    {
        draw = true;



        picture_box.MouseMove += PictureBox_Move;

    }
    private void PictureBox_Move(object sender, MouseEventArgs e)
    {
        if (draw && e.Button == MouseButtons.Left)
        {

            using (Graphics g = picture_box.CreateGraphics())
            {
                g.FillEllipse(Brushes.Black, e.X, e.Y, 6, 6);
            }
        }
    }




}

