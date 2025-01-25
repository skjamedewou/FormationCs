namespace Delegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void fillTextBox(int x);
        string textvalue = "";

        public void FillMathNote(int ExamNote)
        {
            textvalue += "Your Math Note is : " + ExamNote + Environment.NewLine;
        }
        public void FillChemistryNote(int ExamNote)
        {
            textvalue += "Your Chemistry Note is : " + ExamNote + Environment.NewLine;
        }
        public void ShowInTextBox()
        {
            textBox1.Text = textvalue;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //fillTextBox filltext = FillMathNote;
            fillTextBox filltext = new fillTextBox( FillMathNote);
            filltext += FillChemistryNote;

            //filltext(80);
            filltext.Invoke(80);
            ShowInTextBox();
        }
    }
}
