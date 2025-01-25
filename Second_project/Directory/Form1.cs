namespace Directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DirectoryInfo dr = new DirectoryInfo("temp");
            DirectoryInfo dr = new DirectoryInfo(@"C:\temp");
            dr.Create();
            MessageBox.Show("Folder was created");
            
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
             
            //Directory.Move("temp", @"C:\newfolder\temp");
            // Directory.Delete("");
        }
    }
}
