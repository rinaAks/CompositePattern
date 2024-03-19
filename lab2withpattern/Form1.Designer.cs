namespace lab2withpattern;

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
        btStart = new Button();
        tbOutput = new RichTextBox();
        SuspendLayout();
        // 
        // btStart
        // 
        btStart.Font = new Font("Neue Machina", 11.999999F);
        btStart.Location = new Point(110, 179);
        btStart.Name = "btStart";
        btStart.Size = new Size(94, 43);
        btStart.TabIndex = 0;
        btStart.Text = "Старт";
        btStart.UseVisualStyleBackColor = true;
        btStart.Click += btStart_Click;
        // 
        // tbOutput
        // 
        tbOutput.Font = new Font("Neue Machina", 11.999999F);
        tbOutput.Location = new Point(393, 41);
        tbOutput.Name = "tbOutput";
        tbOutput.Size = new Size(618, 414);
        tbOutput.TabIndex = 1;
        tbOutput.Text = "";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1062, 610);
        Controls.Add(tbOutput);
        Controls.Add(btStart);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button btStart;
    public RichTextBox tbOutput;
}
