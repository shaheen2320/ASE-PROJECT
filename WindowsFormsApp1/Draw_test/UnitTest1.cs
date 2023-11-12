using Microsoft.VisualStudio.TestTools.UnitTesting;
using ASE_TASK_1;


namespace Draw_tests
{
    [TestClass]
    public class DrawParserClassTests
    {
        [TestMethod]
        public void DrawingCommands_DrawRectangle_DrawsRectangle()
        {
            // Arrange
            Picture_Box pictureBox = new Picture_Box();
            Draw_Parser_class drawParser = new Draw_Parser_class(pictureBox);
            string command = "draw rectangle 10 10 50 30";

            // Act
            drawParser.Drawing_Commands(command);

            
        }

        
    }
}
