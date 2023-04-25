namespace _2_TextBox_ComboBox_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            operation.Items.Add("+");
            operation.Items.Add("-");
            operation.Items.Add("*");
            operation.Items.Add("/");
            operation.SelectedItem = operation.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double op1 = Convert.ToDouble(operand1.Text);
                double op2 = Convert.ToDouble(operand2.Text);
                // object obj = operation.Items[operation.SelectedIndex];
                object obj = operation.SelectedItem;
                string op = obj.ToString();
                switch (op)
                {
                    case "+":
                        result.Text = (op1 + op2).ToString();
                        break;
                    case "-":
                        result.Text = (op1 - op2).ToString();
                        break;
                    case "*":
                        result.Text = (op1 * op2).ToString();
                        break;
                    case "/":
                        result.Text = (op1 / op2).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}