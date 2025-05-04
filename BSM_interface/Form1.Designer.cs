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
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        textBox5 = new System.Windows.Forms.TextBox();
        numericUpDown4 = new System.Windows.Forms.NumericUpDown();
        textBox6 = new System.Windows.Forms.TextBox();
        numericUpDown5 = new System.Windows.Forms.NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
        SuspendLayout();
        // 
        // numericUpDown1
        // 
        numericUpDown1.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown1.Location = new System.Drawing.Point(11, 32);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new System.Drawing.Size(161, 27);
        numericUpDown1.TabIndex = 0;
        numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
        // 
        // numericUpDown2
        // 
        numericUpDown2.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown2.Location = new System.Drawing.Point(11, 81);
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new System.Drawing.Size(161, 27);
        numericUpDown2.TabIndex = 1;
        numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
        // 
        // numericUpDown3
        // 
        numericUpDown3.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown3.Location = new System.Drawing.Point(11, 131);
        numericUpDown3.Name = "numericUpDown3";
        numericUpDown3.Size = new System.Drawing.Size(161, 27);
        numericUpDown3.TabIndex = 2;
        numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.DarkGray;
        label1.Location = new System.Drawing.Point(11, 328);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(161, 55);
        label1.TabIndex = 4;
        label1.Text = "0";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBox1
        // 
        textBox1.BackColor = System.Drawing.Color.Aquamarine;
        textBox1.Location = new System.Drawing.Point(11, 8);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(161, 27);
        textBox1.TabIndex = 5;
        textBox1.Text = "Current Stock Price";
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.Color.Aquamarine;
        textBox2.Location = new System.Drawing.Point(11, 56);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(161, 27);
        textBox2.TabIndex = 6;
        textBox2.Text = "Time To Maturity";
        // 
        // textBox3
        // 
        textBox3.BackColor = System.Drawing.Color.Aquamarine;
        textBox3.Location = new System.Drawing.Point(11, 106);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(161, 27);
        textBox3.TabIndex = 7;
        textBox3.Text = "StrikePrice";
        // 
        // textBox4
        // 
        textBox4.BackColor = System.Drawing.Color.Gold;
        textBox4.Location = new System.Drawing.Point(11, 298);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(161, 27);
        textBox4.TabIndex = 8;
        textBox4.Text = "Black-Scholes Value";
        // 
        // textBox5
        // 
        textBox5.BackColor = System.Drawing.Color.Aquamarine;
        textBox5.Location = new System.Drawing.Point(11, 155);
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(161, 27);
        textBox5.TabIndex = 10;
        textBox5.Text = "RiskFreeRate";
        // 
        // numericUpDown4
        // 
        numericUpDown4.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown4.Location = new System.Drawing.Point(11, 180);
        numericUpDown4.Name = "numericUpDown4";
        numericUpDown4.Size = new System.Drawing.Size(161, 27);
        numericUpDown4.TabIndex = 9;
        numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
        // 
        // textBox6
        // 
        textBox6.BackColor = System.Drawing.Color.Aquamarine;
        textBox6.Location = new System.Drawing.Point(11, 204);
        textBox6.Name = "textBox6";
        textBox6.Size = new System.Drawing.Size(161, 27);
        textBox6.TabIndex = 12;
        textBox6.Text = "Volatility";
        // 
        // numericUpDown5
        // 
        numericUpDown5.BackColor = System.Drawing.SystemColors.ActiveBorder;
        numericUpDown5.Location = new System.Drawing.Point(11, 229);
        numericUpDown5.Name = "numericUpDown5";
        numericUpDown5.Size = new System.Drawing.Size(161, 27);
        numericUpDown5.TabIndex = 11;
        numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        BackColor = System.Drawing.Color.CadetBlue;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox6);
        Controls.Add(numericUpDown5);
        Controls.Add(textBox5);
        Controls.Add(numericUpDown4);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
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
        ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.NumericUpDown numericUpDown4;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.NumericUpDown numericUpDown5;

    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown numericUpDown3;

    private System.Windows.Forms.NumericUpDown numericUpDown1;

    #endregion
}