namespace GPA.TT
{
    public partial class Form1 : Form
    {
        double sum = 0;
        int n = 0;
        double max=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strInput = textBoxGPA_input.Text;
            double dInput = double.Parse(strInput);
            if (dInput < max)
                max = dInput;
             sum = sum + dInput;    
            n = n + 1;
            double result = sum / n;    
            textBoxGPAx.Text = result.ToString();

            textBoxGPA_input.Text = "";
            textBoxMAXGPA.Text = max.ToString();
              
         }
    }
}