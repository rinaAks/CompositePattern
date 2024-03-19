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
        label1 = new Label();
        btAddMenu = new Button();
        tbAddMenu = new TextBox();
        lbAddMenu = new Label();
        cbMenus = new ComboBox();
        label2 = new Label();
        btAddItem = new Button();
        tbAddItem = new TextBox();
        lbAddItem = new Label();
        numPrice = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
        SuspendLayout();
        // 
        // btStart
        // 
        btStart.Font = new Font("Neue Machina", 11.999999F);
        btStart.Location = new Point(624, 22);
        btStart.Name = "btStart";
        btStart.Size = new Size(203, 43);
        btStart.TabIndex = 0;
        btStart.Text = "Показать меню";
        btStart.UseVisualStyleBackColor = true;
        btStart.Click += btStart_Click;
        // 
        // tbOutput
        // 
        tbOutput.Font = new Font("Neue Machina", 11.999999F);
        tbOutput.Location = new Point(400, 87);
        tbOutput.Name = "tbOutput";
        tbOutput.Size = new Size(618, 473);
        tbOutput.TabIndex = 1;
        tbOutput.Text = "";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Neue Machina", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label1.Location = new Point(75, 116);
        label1.Name = "label1";
        label1.Size = new Size(0, 26);
        label1.TabIndex = 2;
        // 
        // btAddMenu
        // 
        btAddMenu.Font = new Font("Neue Machina", 11.999999F);
        btAddMenu.Location = new Point(53, 128);
        btAddMenu.Name = "btAddMenu";
        btAddMenu.Size = new Size(203, 43);
        btAddMenu.TabIndex = 3;
        btAddMenu.Text = "Добавить меню";
        btAddMenu.UseVisualStyleBackColor = true;
        btAddMenu.Click += btAddMenu_Click;
        // 
        // tbAddMenu
        // 
        tbAddMenu.Font = new Font("Neue Machina", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
        tbAddMenu.Location = new Point(53, 86);
        tbAddMenu.Name = "tbAddMenu";
        tbAddMenu.Size = new Size(203, 27);
        tbAddMenu.TabIndex = 5;
        tbAddMenu.Text = "Впишите название меню";
        tbAddMenu.MouseClick += tbAddMenu_MouseClick;
        // 
        // lbAddMenu
        // 
        lbAddMenu.AutoSize = true;
        lbAddMenu.Font = new Font("Neue Machina", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lbAddMenu.ForeColor = SystemColors.Desktop;
        lbAddMenu.Location = new Point(53, 184);
        lbAddMenu.Name = "lbAddMenu";
        lbAddMenu.Size = new Size(26, 26);
        lbAddMenu.TabIndex = 6;
        lbAddMenu.Text = "  ";
        // 
        // cbMenus
        // 
        cbMenus.FormattingEnabled = true;
        cbMenus.Location = new Point(53, 328);
        cbMenus.Name = "cbMenus";
        cbMenus.Size = new Size(203, 28);
        cbMenus.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Neue Machina", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label2.Location = new Point(53, 282);
        label2.Name = "label2";
        label2.Size = new Size(173, 26);
        label2.TabIndex = 9;
        label2.Text = "Выберите меню";
        // 
        // btAddItem
        // 
        btAddItem.Font = new Font("Neue Machina", 11.999999F);
        btAddItem.Location = new Point(53, 431);
        btAddItem.Name = "btAddItem";
        btAddItem.Size = new Size(203, 43);
        btAddItem.TabIndex = 10;
        btAddItem.Text = "Добавить блюдо";
        btAddItem.UseVisualStyleBackColor = true;
        btAddItem.Click += btAddItem_Click;
        // 
        // tbAddItem
        // 
        tbAddItem.Font = new Font("Neue Machina", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
        tbAddItem.Location = new Point(53, 382);
        tbAddItem.Name = "tbAddItem";
        tbAddItem.Size = new Size(203, 27);
        tbAddItem.TabIndex = 11;
        tbAddItem.Text = "Впишите название блюда";
        tbAddItem.MouseClick += tbAddItem_MouseClick;
        // 
        // lbAddItem
        // 
        lbAddItem.AutoSize = true;
        lbAddItem.Font = new Font("Neue Machina", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lbAddItem.ForeColor = SystemColors.Desktop;
        lbAddItem.Location = new Point(53, 486);
        lbAddItem.Name = "lbAddItem";
        lbAddItem.Size = new Size(26, 26);
        lbAddItem.TabIndex = 12;
        lbAddItem.Text = "  ";
        // 
        // numPrice
        // 
        numPrice.Font = new Font("Neue Machina", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        numPrice.Location = new Point(282, 382);
        numPrice.Name = "numPrice";
        numPrice.Size = new Size(55, 27);
        numPrice.TabIndex = 13;
        numPrice.Value = new decimal(new int[] { 50, 0, 0, 0 });
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1062, 610);
        Controls.Add(numPrice);
        Controls.Add(lbAddItem);
        Controls.Add(tbAddItem);
        Controls.Add(btAddItem);
        Controls.Add(label2);
        Controls.Add(cbMenus);
        Controls.Add(lbAddMenu);
        Controls.Add(tbAddMenu);
        Controls.Add(btAddMenu);
        Controls.Add(label1);
        Controls.Add(tbOutput);
        Controls.Add(btStart);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void TbAddMenu_MouseClick(object sender, MouseEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void TbAddMenu_KeyDown(object sender, KeyEventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private Button btStart;
    public RichTextBox tbOutput;
    private Label label1;
    private Button btAddMenu;
    private TextBox tbAddMenu;
    private Label lbAddMenu;
    private ComboBox cbMenus;
    private Label label2;
    private Button btAddItem;
    private TextBox tbAddItem;
    private Label lbAddItem;
    private NumericUpDown numPrice;
}
