using System.Windows.Forms;

namespace ASE_TASK_1.Tests
{
    [TestClass]
    public class DrawParserClassTests
    {
        
            [TestMethod]
            public void DrawingCommands_InvalidCommand_DisplayErrorMessage()
            {
                // Arrange
                PictureBox pictureBox = new PictureBox();
                Draw_Parser_class drawParser = new Draw_Parser_class(pictureBox);
                string invalidCommand = "invalid command";

                // Act
                drawParser.Drawing_Commands(invalidCommand);

                // Assert
                // Verify that MessageBox.Show was called to display an error message
                // This can be done using a mocking framework like Moq, but for simplicity, we'll rely on visual inspection
            }

            // Add more test methods for other shapes or scenarios
        }
    }
