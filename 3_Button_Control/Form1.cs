namespace _3_Button_Control
{
    public partial class Form1 : Form
    {
        int index = 1;
        public Form1()
        {
            InitializeComponent();
            Height = 220;
            Width = 300;
            Text = "Слайд-шоу";
            picture.Location = new Point(80, 10);
            //picture.Image = Image.FromFile("1.bmp");
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            start.Location = new Point(30, 120);
            start.Text = "Старт";
            start.Width = 100;
            start.Height = 40;
            stop.Location = new Point(160, 120);
            stop.Text = "Стоп";
            stop.Width = 100;
            stop.Height = 40;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++index;
            if (index > 5)
                index = 1;
            picture.Image = Image.FromFile(@"pics\" + index + ".png");
        }
    }
}