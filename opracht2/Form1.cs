namespace opracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int oplosing1 = 1234 * 54321;

            string s1 = $"1234 * 54321 = {oplosing1}";

            label1.Text = s1;

            int oplosing2 = 22222 * 33333;

            string s2 = $"22222 * 33333 = {oplosing2}";

            label2.Text = s2;

            bool oplosing3 = oplosing1 < oplosing2;


            string s3 = $"1234 * 54321  > 22222 * 33333 = {oplosing3}";

            label3.Text = s3;
        }
    }
}