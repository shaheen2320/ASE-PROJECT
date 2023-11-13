using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using System.Windows.Forms;

namespace ASE_TASK_1.TEST;
[TestClass]
public class DrawPaintingClassTests
{
    private Draw_Parser_class _parserClass;
    private PictureBox _pictureBox1;

    [TestInitialize]

    public void Setup()

    {
        _pictureBox1 = new PictureBox();
        _parserClass = new Draw_Parser_class(_pictureBox1);

    }

    [TestMethod]
    public void Drawing_Commands_DrawdRectangle_checkValidCommand_()
    {
        string command = "draw rectangle 10 20 30 40";
        try
        {
            _parserClass.Drawing_Commands(command);

        }
        catch (Exception ex)
        {
            Assert.Fail($"syntax error: {ex.Message}");
        }
    }
    [TestMethod]
    public void Drawing_Commands_Drawdcircle_checkValidCommand_()
    {
        string command = "draw circle 10 20 30";
        try
        {
            _parserClass.Drawing_Commands(command);


        }
        catch (Exception ex)
        {
            Assert.Fail($"syntax error: {ex.Message}");
        }
    }
    [TestMethod]
    public void Drawing_Commands_Drawdline_checkValidCommand_()
    {
        string command = "draw line 10 20 ";
        try
        {
            _parserClass.Drawing_Commands(command);


        }
        catch (Exception ex)
        {
            Assert.Fail($"syntax error: {ex.Message}");
        }
    }
    [TestMethod]
    public void Drawing_Commands_Drawdtriangle_checkValidCommand_()
    {
        string command = "draw triangle 10 20 30 40 50 60";
        try
        {
            _parserClass.Drawing_Commands(command);


        }
        catch (Exception ex)
        {
            Assert.Fail($"syntax error: {ex.Message}");
        }
    }
    [TestMethod]
    public void Drawing_Commands__checkValidCommand_()
    {
        string command = "clear surface";
        try
        {
            _parserClass.Drawing_Commands(command);


        }
        catch (Exception ex)
        {
            Assert.Fail($"syntax error: {ex.Message}");
        }
    }



    [TestMethod]

    public void Drawing_Commands_InvalidCommand_ThrowsException()
    {
        string command = "invalid command";
        Assert.ThrowsException<ArgumentException>(() => _parserClass.Drawing_Commands(command));
    }
}