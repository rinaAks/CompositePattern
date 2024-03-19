namespace lab2
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
            tbOutput = new RichTextBox();
            btStart = new Button();
            SuspendLayout();
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(234, 84);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(422, 274);
            tbOutput.TabIndex = 5;
            tbOutput.Text = "";
            // 
            // btStart
            // 
            btStart.Location = new Point(385, 403);
            btStart.Name = "btStart";
            btStart.Size = new Size(94, 29);
            btStart.TabIndex = 6;
            btStart.Text = "Начать";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 507);
            Controls.Add(btStart);
            Controls.Add(tbOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox tbOutput;
        private Button btStart;
    }
}
