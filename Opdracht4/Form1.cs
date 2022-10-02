namespace Opdracht4
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            double t1 = Convert.ToDouble(nr1.Text);
            double t2 = Convert.ToDouble(nr2.Text);
            double t3 = Convert.ToDouble(nr3.Text);
            double t4 = Convert.ToDouble(nr4.Text);

            double pr1 = Convert.ToDouble(PE1.Text);
            double pr2 = Convert.ToDouble(PE2.Text);
            double pr3 = Convert.ToDouble(PE3.Text);
            double pr4 = Convert.ToDouble(PE4.Text);


            double result1 = t1 * pr1;
            double result2 = t2 * pr2;
            double result3 = t3 * pr3;
            double result4 = t4 * pr4;

            exp1.Text = result1.ToString();
            exp2.Text = result2.ToString();
            exp3.Text = result3.ToString();
            exp4.Text = result4.ToString();

            double sbTotal = result1 + result2 + result3 + result4;
            sublabel.Text = "$" + sbTotal.ToString();

            double TVA = Convert.ToDouble(taxlabel.Text);
            double STAX = sbTotal * TVA;
            saleslabel.Text = "$" + STAX.ToString();
            double ship = Convert.ToDouble(shippinglabel.Text);
            double grtotal = sbTotal + STAX + ship;

            garndlabel.Text = "$" + grtotal.ToString();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}