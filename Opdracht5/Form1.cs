namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double convertToF = Convert.ToDouble(CtoF.Text) * 9 /5 + 32;
            CtoF.Text = convertToF.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double convertToC = (Convert.ToDouble(FtoC.Text) - 32) * 5 / 9;
            FtoC.Text = convertToC.ToString();
        }
    }
}