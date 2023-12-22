namespace Encriypter
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
            inputTB = new TextBox();
            outputTB = new TextBox();
            button1 = new Button();
            codeTB = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // inputTB
            // 
            inputTB.Location = new Point(39, 30);
            inputTB.Name = "inputTB";
            inputTB.Size = new Size(100, 23);
            inputTB.TabIndex = 0;
            // 
            // outputTB
            // 
            outputTB.Location = new Point(39, 59);
            outputTB.Name = "outputTB";
            outputTB.Size = new Size(100, 23);
            outputTB.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(145, 59);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Kodla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // codeTB
            // 
            codeTB.Location = new Point(39, 88);
            codeTB.Name = "codeTB";
            codeTB.Size = new Size(100, 23);
            codeTB.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(39, 117);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(56, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Kodla";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 306);
            Controls.Add(checkBox1);
            Controls.Add(codeTB);
            Controls.Add(button1);
            Controls.Add(outputTB);
            Controls.Add(inputTB);
            Name = "Form1";
            Text = "3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTB;
        private TextBox outputTB;
        private Button button1;
        public TextBox codeTB;
        private CheckBox checkBox1;
    }
}
