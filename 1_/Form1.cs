using System.Diagnostics;

namespace _1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "������";
            label1.Parent = this;
            label1.Location = new Point(10, 10); // Location � ������� ������ �������� ����
            // label1.AutoSize = true; //���������� ������� ������� ��� ����������
            label1.Width = 200; // ������ �������
            label1.Height = 200; // ������ �������
            label1.BorderStyle = BorderStyle.Fixed3D; // ��������� ����� ������
            BackColor = Color.AliceBlue; // ���� ���� �����
            label1.BackColor = Color.Orange; // ���� ���� �������
            label1.ForeColor = Color.FromArgb(255, 0, 0); // ���� ������ �� �������
            label1.Cursor = Cursors.Hand; // ��� �������
            Opacity = 0.8; // ������� ������������ �����
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Text = String.Format("X = {0}  Y = {1}", e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("X = {0}  Y = {1}", e.X, e.Y);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://msdn.microsoft.com/ru-ru/default.aspx", UseShellExecute = true });
            //Net Framewrok
            //System.Diagnostics.Process.Start("https://msdn.microsoft.com/ru-ru/default.aspx");

            // ��������� � ������� ��������
            // https://learn.microsoft.com/en-us/answers/questions/809281/net6-system-diagnostics-process-start-error?orderby=newest

        }


    }
}