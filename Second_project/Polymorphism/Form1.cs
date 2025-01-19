namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Charles");
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Charles", 2000);
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Charles", 2000, "teacher");
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Employee2 employee = new Employee2();
            string messageText = employee.SetValues(1, "Charles", 2000);
            textBox1.Text = messageText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Teacher2 employee = new Teacher2();
            string messageText = employee.SetValues(1, "Charles", 2000);
            textBox1.Text = messageText;
        }
    }
}
