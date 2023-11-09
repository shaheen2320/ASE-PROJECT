using System;
using System.Windows.Forms;

namespace AseComponent_1
{
    public partial class form_1 : Form
    {
        private Draw_Parser_class commandParser;

        public object CompleteProgramTextBox { get; private set; }

        public form_1()
        {
            InitializeComponent();
            commandParser = new Draw_Parser_class(pictureBox1);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string programCode = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string completeProgram = textBox1.Text;
            
            string userInput = textBox1.Text;
            commandParser.drawing_Commands(userInput);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

