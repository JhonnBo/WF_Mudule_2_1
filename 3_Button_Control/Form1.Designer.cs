namespace _3_Button_Control
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            start = new Button();
            stop = new Button();
            picture = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // start
            // 
            start.Location = new Point(88, 68);
            start.Name = "start";
            start.Size = new Size(112, 34);
            start.TabIndex = 0;
            start.Text = "button1";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Location = new Point(267, 68);
            stop.Name = "stop";
            stop.Size = new Size(112, 34);
            stop.TabIndex = 1;
            stop.Text = "button2";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // picture
            // 
            picture.Image = Properties.Resources._11;
            picture.Location = new Point(466, 68);
            picture.Name = "picture";
            picture.Size = new Size(121, 97);
            picture.TabIndex = 2;
            picture.UseVisualStyleBackColor = true;
            picture.MouseClick += picture_MouseClick;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picture);
            Controls.Add(stop);
            Controls.Add(start);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button start;
        private Button stop;
        private Button picture;
        private System.Windows.Forms.Timer timer1;
    }
}