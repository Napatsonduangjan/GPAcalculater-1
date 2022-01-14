namespace GPACalculater
{
    public partial class Form1 : Form
    {
        double sum = 0;
        int n = 0;
        double max = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //4.00
            string  strInput = textBoxGPA_input.Text;
            double dInput = double.Parse(strInput);
            
            if (dInput > max)
                max = dInput;
            
            //sum 0.0 + "4.00"
            sum = sum + dInput;
            n = n + 1;
            
            //convert double to sstring and settext to textbox
            double result = sum / n;
            textBoxGPAx.Text = result.ToString();
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = max.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAx.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMaxGPA.Text = "";
            textBoxMinGPA.Text = "";
            
            sum = 0;
            n = 0;  
        }
    }
}