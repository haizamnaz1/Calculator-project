namespace Calculator_project
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
            TextBoxDisplay = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btnplus = new Button();
            btnminus = new Button();
            btnmultiply = new Button();
            btndevision = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // TextBoxDisplay
            // 
            TextBoxDisplay.Font = new Font("Segoe UI", 20F);
            TextBoxDisplay.Location = new Point(51, 27);
            TextBoxDisplay.Name = "TextBoxDisplay";
            TextBoxDisplay.ReadOnly = true;
            TextBoxDisplay.Size = new Size(241, 43);
            TextBoxDisplay.TabIndex = 0;
            TextBoxDisplay.TextAlign = HorizontalAlignment.Right;
            TextBoxDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F);
            btn1.Location = new Point(51, 99);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(132, 99);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(217, 99);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(51, 140);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 23);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(132, 140);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 23);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 9F);
            btn6.Location = new Point(217, 140);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 23);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(51, 179);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 23);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(132, 179);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 23);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(217, 179);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 23);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(132, 217);
            btn10.Name = "btn10";
            btn10.Size = new Size(75, 23);
            btn10.TabIndex = 10;
            btn10.Text = "0";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Segoe UI", 9F);
            btnplus.Location = new Point(73, 259);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(49, 23);
            btnplus.TabIndex = 11;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(128, 259);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(44, 23);
            btnminus.TabIndex = 12;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnminus_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.Location = new Point(178, 259);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(48, 23);
            btnmultiply.TabIndex = 13;
            btnmultiply.Text = "x";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += btnmultiply_Click;
            // 
            // btndevision
            // 
            btndevision.Location = new Point(232, 259);
            btndevision.Name = "btndevision";
            btndevision.Size = new Size(48, 23);
            btndevision.TabIndex = 14;
            btndevision.Text = "/";
            btndevision.UseVisualStyleBackColor = true;
            btndevision.Click += btndevision_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(51, 301);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(241, 23);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 374);
            Controls.Add(btnEqual);
            Controls.Add(btndevision);
            Controls.Add(btnmultiply);
            Controls.Add(btnminus);
            Controls.Add(btnplus);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(TextBoxDisplay);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxDisplay;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btnplus;
        private Button btnminus;
        private Button btnmultiply;
        private Button btndevision;
        private Button btnEqual;
    }
}
