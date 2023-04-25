namespace _2_TextBox_ComboBox_Control
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
            operand1 = new TextBox();
            operand2 = new TextBox();
            operation = new ComboBox();
            button1 = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // operand1
            // 
            operand1.Location = new Point(12, 12);
            operand1.Name = "operand1";
            operand1.Size = new Size(95, 31);
            operand1.TabIndex = 0;
            // 
            // operand2
            // 
            operand2.Location = new Point(192, 12);
            operand2.Name = "operand2";
            operand2.Size = new Size(95, 31);
            operand2.TabIndex = 2;
            // 
            // operation
            // 
            operation.DropDownStyle = ComboBoxStyle.DropDownList;
            operation.FormattingEnabled = true;
            operation.Location = new Point(113, 12);
            operation.Name = "operation";
            operation.Size = new Size(73, 33);
            operation.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(293, 10);
            button1.Name = "button1";
            button1.Size = new Size(53, 34);
            button1.TabIndex = 3;
            button1.Text = "=";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // result
            // 
            result.BorderStyle = BorderStyle.FixedSingle;
            result.Location = new Point(352, 15);
            result.Name = "result";
            result.Size = new Size(80, 25);
            result.TabIndex = 3;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 61);
            Controls.Add(result);
            Controls.Add(button1);
            Controls.Add(operation);
            Controls.Add(operand2);
            Controls.Add(operand1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox operand1;
        private TextBox operand2;
        private ComboBox operation;
        private Button button1;
        private Label result;
    }
}