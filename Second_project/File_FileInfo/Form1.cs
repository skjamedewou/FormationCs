using System.IO;

namespace File_FileInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.Create("firstfile.txt");
            if (!File.Exists("secondfile.txt"))
            {
                FileInfo ourfile = new FileInfo("secondfile.txt");
                ourfile.Create();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is first line");
            sw.WriteLine("This is second line");
            sw.Flush();
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while (!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            textBox1.Text = text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Copy("third.txt", @"C:\temp\thirdfile.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileInfo ourfile = new FileInfo("third.txt");
            string name = ourfile.FullName;
            string accessTime = ourfile.LastAccessTime.ToString();
            MessageBox.Show(name +"\n" + accessTime);
        }
    }
}
