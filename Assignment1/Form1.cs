namespace Assignment1
{
    public partial class Form1 : Form
    {
        private Boolean stateOfTheImage = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!stateOfTheImage)
            {
                pictureBox1.Visible = false;
                stateOfTheImage = true;
                button1.Text = "Show";
                textBox1.Text = "Picture is not visible";
            }
            else
            {
                pictureBox1.Visible = true;
                stateOfTheImage = false;
                button1.Text = "Hide";
                textBox1.Text = "Picture is visible";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}