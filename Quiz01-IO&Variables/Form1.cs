namespace Quiz01_IO_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q2SExampleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go Jays!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("6");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("To output two decimal places use F2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4 items at 2.25 each with tax will be $10.17");
        }

        private void q01Button_Click(object sender, EventArgs e)
        {
            q1OutputLabel.Text = "Go Bears!";

        }

        private void q2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void q02Button_Click(object sender, EventArgs e)
        {
            q2OutputLabel.Text = q2TextBox.Text;
            q2OutputLabel.Text = "Go " + q2TextBox.Text;


        }

        private void q03Button_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            //I tried to remember but I couldnt. When I tried the stuff i remembered I just got errors.
           
            q3OutputLabel.Text = num1Box.Text + num2Box.Text;
            q3OutputLabel.Text = Convert.ToString(num1 * num2);
            
            
            
        }
    }
}
