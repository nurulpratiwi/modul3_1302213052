namespace modul3_1302213052
{
    public partial class Form1 : Form
    {
        int angka1;
        int angka2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           if(angka1 == 0)
            {
                angka1 = int.Parse(label1.Text);
            }
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(angka2 == 0)
            {
                angka2 = int.Parse(label1.Text);
            }
            label1.Text = "" + (angka1 + angka2);
            angka1 = angka1 + angka2;
            angka2 = 0;

        }
    }
}