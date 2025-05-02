namespace BSM_interface;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        numericUpDown1 = new System.Windows.Forms.NumericUpDown();
        numericUpDown2 = new System.Windows.Forms.NumericUpDown();
        numericUpDown3 = new System.Windows.Forms.NumericUpDown();
        label1 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        SuspendLayout();
        // 
        // numericUpDown1
        // 
        numericUpDown1.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown1.Location = new System.Drawing.Point(19, 68);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(161, 27);
        numericUpDown1.TabIndex = 0;
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // numericUpDown2
        // 
        numericUpDown2.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown2.Location = new System.Drawing.Point(19, 117);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(161, 27);
        numericUpDown2.TabIndex = 1;
        numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
        // 
        // numericUpDown3
        // 
        numericUpDown3.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown3.Location = new System.Drawing.Point(19, 167);
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new System.Drawing.Size(161, 27);
        numericUpDown3.TabIndex = 2;
        numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.DarkGray;
        label1.Location = new System.Drawing.Point(301, 188);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(141, 35);
        label1.TabIndex = 4;
        label1.Text = "0";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label1.Click += label1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        BackColor = System.Drawing.Color.DarkOrange;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(numericUpDown1);
        Controls.Add(numericUpDown2);
        Controls.Add(numericUpDown3);
        ImeMode = System.Windows.Forms.ImeMode.Off;
        Location = new System.Drawing.Point(19, 19);
        TransparencyKey = System.Drawing.Color.White;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown numericUpDown3;

    private System.Windows.Forms.NumericUpDown numericUpDown1;

    #endregion
}