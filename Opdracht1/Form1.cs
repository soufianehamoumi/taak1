namespace Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            String ST = $"hello {Environment.UserName}. het is nu  {DateTime.Now.ToShortTimeString()} op {DateTime.Now.ToShortTimeString}";
            lb1.Text = ST;

        }

        private void lb1_Click(object sender, EventArgs e)
        {

           
        }
    }
}