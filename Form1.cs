namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double radio1, area1, volumen1;
            radio1 = double.Parse(textBox1.Text);
            area1 = 4 * pi * (radio1 * radio1);
            volumen1 = 4 * pi * (radio1 * radio1 * radio1) / 3;
            textBox2.Text = area1.ToString();
            textBox3.Text = volumen1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double altura1, base1;
            double area2;
            base1 = double.Parse(textBox4.Text);
            altura1 = double.Parse(textBox5.Text);
            area2 = (base1 * altura1) / 2;
            textBox6.Text = area2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double arista1;
            double area3;
            double volumen2;
            arista1 = double.Parse(textBox7.Text);
            area3 = 6 * (arista1 * arista1);
            volumen2 = arista1 * arista1 * arista1;
            textBox8.Text = area3.ToString();
            textBox9.Text = volumen2.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            const double pi = 3.141592;
            double area4, volumen3;
            double altura2, radio2;
            altura2 = double.Parse(textBox11.Text);
            radio2 = double.Parse(textBox10.Text);
            area4 = 2 * pi * radio2 * altura2;
            volumen3 = pi * (radio2 * radio2) * altura2;
            textBox12.Text = area4.ToString();
            textBox13.Text = volumen3.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double D, d;
            double area5;
            D = double.Parse(textBox14.Text);
            d = double.Parse(textBox15.Text);
            area5 = (D * d) / 2;
            textBox16.Text = area5.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox16.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double arista2;
            double area6, volumen4;
            double raizCuadrada2 = Math.Sqrt(2);
            double raizCuadrada3 = Math.Sqrt(3);
            arista2 = double.Parse(textBox17.Text);
            area6 = 2 * raizCuadrada3 * (arista2 * arista2);
            volumen4 = (raizCuadrada2 / 3) * (arista2 * arista2 * arista2);
            textBox18.Text = area6.ToString();
            textBox19.Text = volumen4.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox17.Text = " ";
            textBox18.Text = " ";
            textBox19.Text = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}