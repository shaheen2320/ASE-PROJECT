using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_TASK_1;
using System.Windows.Forms;

namespace ASE_TASK_1.Tests
{
    [TestClass]
    public class Draw_Parser_classTests
    {
        [TestMethod]
        public void InvalidParameters_check_drawrectangle()
        {

            PictureBox pictureBox = new PictureBox();
            Draw_Parser_class drawParser = new Draw_Parser_class(pictureBox);
            string command = "draw rectangle 20 40 60";


            try
            {
                drawParser.Drawing_Commands(command);
                Assert.Fail("Unexpected ArgumentException thrown.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        [TestMethod]
        public void InvalidParameters_check_drawCircle()
        {
            // Arrange
            PictureBox pictureBox = new PictureBox();
            Draw_Parser_class drawParser = new Draw_Parser_class(pictureBox);
            string command = "draw circle 30 50";

            try
            {
                drawParser.Drawing_Commands(command);
                Assert.Fail("Unexpected ArgumentException thrown.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }


        }
    }
}


        

