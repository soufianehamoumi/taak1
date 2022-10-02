namespace Opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t1 = Convert.ToDouble(QT1.Text);
            double t2 = Convert.ToDouble(Qt2.Text);
            double t3 = Convert.ToDouble(QT3.Text);
            double t4 = Convert.ToDouble(QT4.Text);

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

            double TVA = sbTotal * 7 / 100;
            taxlabel.Text = "$" + TVA.ToString();

            double shipp = 0;

            if(sbTotal < 20)
            {
                shipp = 5;
                shippinglabel.Text = "$" + shipp.ToString();
            }else if(sbTotal < 50 && sbTotal > 20)
            {
                shipp = 7.5;
                shippinglabel.Text = "$" + shipp.ToString();
            }else if(sbTotal <75 && sbTotal > 50)
            {
                shipp = 10;
                shippinglabel.Text = "$" + shipp.ToString();
            }else
            {
                shipp = 0;
                shippinglabel.Text = "$" + shipp.ToString();

            }
            double grtotal = sbTotal + TVA + shipp;

            garndlabel.Text = "$" + grtotal.ToString();

        }
    }
}