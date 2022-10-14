namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            funkcja();

        }

        private void funkcja()
        {
            if (numericUpDown4.Value <= 255 && numericUpDown3.Value <= 255 && numericUpDown2.Value <= 255 && numericUpDown1.Value <= 255 && numericUpDown5.Value <= 30)
            {
                label2.Visible = true;
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
                label2.Visible = false;
            }


        }
        private void button_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
     
 
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
       

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
  

        }
    }
}