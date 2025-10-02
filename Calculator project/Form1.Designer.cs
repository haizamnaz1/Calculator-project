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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBoxDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxDisplay;
    }
}
