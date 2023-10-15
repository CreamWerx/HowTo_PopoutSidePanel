namespace HowTo_PopoutSidePanel;

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
        panel1 = new Panel();
        button1 = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.WindowFrame;
        panel1.Controls.Add(button1);
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 592);
        panel1.TabIndex = 0;
        panel1.MouseLeave += panel1_MouseLeave;
        // 
        // button1
        // 
        button1.Location = new Point(32, 35);
        button1.Name = "button1";
        button1.Size = new Size(127, 37);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(867, 595);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "Form1";
        SizeChanged += Form1_SizeChanged;
        MouseEnter += Form1_MouseEnter;
        MouseLeave += Form1_MouseLeave;
        MouseMove += Form1_MouseMove;
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button1;
}
