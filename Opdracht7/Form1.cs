namespace Opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sumNr = Convert.ToDouble(inputNumber.Text);

            double sum = 0;

            for (int i = 0; i <= sumNr; i++)
            {
                sum += i;
               
            }



            result1.Text = "$" + sum.ToString();


        }
    }
}