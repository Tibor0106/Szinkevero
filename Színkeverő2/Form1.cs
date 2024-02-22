namespace Színkeverő2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Length == 0 || textBox2.Text.ToString().Length == 0 || textBox3.Text.ToString().Length == 0)
            {
                return;
            }
            if (int.TryParse(textBox1.Text, out int r) && int.TryParse(textBox2.Text, out int g)
                && int.TryParse(textBox3.Text, out int b))
            {
                trackBar1.Value = r > 255 ? 255 : r;
                trackBar2.Value = g > 255 ? 255 : g;
                trackBar3.Value = b > 255 ? 255 : b;
                Beallit();

            }
            else
            {
                MessageBox.Show("A megott érték nem szám !");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar2.Value.ToString();
            textBox3.Text = trackBar3.Value.ToString();
            Beallit();
        }
        private void Beallit()
        {
            listBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
