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
            label1 = new Label();
            cbFoodType = new ComboBox();
            label2 = new Label();
            cbDoType = new ComboBox();
            tbOutput = new RichTextBox();
            btStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 45);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Выберите еду";
            // 
            // cbFoodType
            // 
            cbFoodType.FormattingEnabled = true;
            cbFoodType.Items.AddRange(new object[] { "бульон", "мясо", "лапша", "рамен" });
            cbFoodType.Location = new Point(52, 88);
            cbFoodType.Name = "cbFoodType";
            cbFoodType.Size = new Size(151, 28);
            cbFoodType.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 225);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 2;
            label2.Text = "Выберите действие";
            // 
            // cbDoType
            // 
            cbDoType.FormattingEnabled = true;
            cbDoType.Items.AddRange(new object[] { "съесть", "подарить", "заморозить" });
            cbDoType.Location = new Point(52, 273);
            cbDoType.Name = "cbDoType";
            cbDoType.Size = new Size(151, 28);
            cbDoType.TabIndex = 3;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(416, 88);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(422, 274);
            tbOutput.TabIndex = 5;
            tbOutput.Text = "";
            // 
            // btStart
            // 
            btStart.Location = new Point(77, 396);
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
            Controls.Add(cbDoType);
            Controls.Add(label2);
            Controls.Add(cbFoodType);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFoodType;
        private Label label2;
        private ComboBox cbDoType;
        private RichTextBox tbOutput;
        private Button btStart;
    }
}
