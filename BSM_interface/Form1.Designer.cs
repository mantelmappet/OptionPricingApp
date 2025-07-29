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
        textBox7 = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        textBox8 = new System.Windows.Forms.TextBox();
        textBox9 = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        textBox10 = new System.Windows.Forms.TextBox();
        textBox11 = new System.Windows.Forms.TextBox();
        textBox12 = new System.Windows.Forms.TextBox();
        textBox13 = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
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
        label1.Location = new System.Drawing.Point(293, 56);
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
        textBox4.Location = new System.Drawing.Point(293, 13);
        textBox4.Multiline = true;
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(161, 46);
        textBox4.TabIndex = 8;
        textBox4.Text = "Call option price(Black-Scholes)";
        textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        textBox4.TextChanged += textBox4_TextChanged;
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
        // textBox7
        // 
        textBox7.BackColor = System.Drawing.Color.Gold;
        textBox7.Location = new System.Drawing.Point(460, 13);
        textBox7.Multiline = true;
        textBox7.Name = "textBox7";
        textBox7.Size = new System.Drawing.Size(161, 46);
        textBox7.TabIndex = 14;
        textBox7.Text = "Put option price (Black-Scholes)";
        textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.DarkGray;
        label2.Location = new System.Drawing.Point(460, 56);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(161, 55);
        label2.TabIndex = 13;
        label2.Text = "0";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.BackColor = System.Drawing.Color.DarkGray;
        label3.Location = new System.Drawing.Point(293, 167);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(161, 55);
        label3.TabIndex = 15;
        label3.Text = "0";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label3.Click += label3_Click;
        // 
        // label4
        // 
        label4.BackColor = System.Drawing.Color.DarkGray;
        label4.Location = new System.Drawing.Point(460, 167);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(161, 55);
        label4.TabIndex = 16;
        label4.Text = "0";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBox8
        // 
        textBox8.BackColor = System.Drawing.Color.Gold;
        textBox8.Location = new System.Drawing.Point(293, 123);
        textBox8.Multiline = true;
        textBox8.Name = "textBox8";
        textBox8.Size = new System.Drawing.Size(161, 46);
        textBox8.TabIndex = 17;
        textBox8.Text = "Call option price(Monte Carlo)";
        textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox9
        // 
        textBox9.BackColor = System.Drawing.Color.Gold;
        textBox9.Location = new System.Drawing.Point(460, 123);
        textBox9.Multiline = true;
        textBox9.Name = "textBox9";
        textBox9.Size = new System.Drawing.Size(161, 46);
        textBox9.TabIndex = 18;
        textBox9.Text = "Put option price(Monte Carlo)";
        textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label5
        // 
        label5.BackColor = System.Drawing.Color.DarkGray;
        label5.Location = new System.Drawing.Point(293, 273);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(161, 55);
        label5.TabIndex = 19;
        label5.Text = "0";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label6
        // 
        label6.BackColor = System.Drawing.Color.DarkGray;
        label6.Location = new System.Drawing.Point(293, 375);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(161, 55);
        label6.TabIndex = 20;
        label6.Text = "0";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // textBox10
        // 
        textBox10.BackColor = System.Drawing.Color.Gold;
        textBox10.Location = new System.Drawing.Point(293, 233);
        textBox10.Multiline = true;
        textBox10.Name = "textBox10";
        textBox10.Size = new System.Drawing.Size(161, 46);
        textBox10.TabIndex = 21;
        textBox10.Text = "Call option price (absolute difference)";
        textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox11
        // 
        textBox11.BackColor = System.Drawing.Color.Gold;
        textBox11.Location = new System.Drawing.Point(293, 331);
        textBox11.Multiline = true;
        textBox11.Name = "textBox11";
        textBox11.Size = new System.Drawing.Size(161, 46);
        textBox11.TabIndex = 22;
        textBox11.Text = "Call option price(percentage diff)";
        textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox12
        // 
        textBox12.BackColor = System.Drawing.Color.Gold;
        textBox12.Location = new System.Drawing.Point(460, 331);
        textBox12.Multiline = true;
        textBox12.Name = "textBox12";
        textBox12.Size = new System.Drawing.Size(161, 46);
        textBox12.TabIndex = 26;
        textBox12.Text = "Put option price(percentage diff)";
        textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // textBox13
        // 
        textBox13.BackColor = System.Drawing.Color.Gold;
        textBox13.Location = new System.Drawing.Point(460, 233);
        textBox13.Multiline = true;
        textBox13.Name = "textBox13";
        textBox13.Size = new System.Drawing.Size(161, 46);
        textBox13.TabIndex = 25;
        textBox13.Text = "Put option price (absolute difference)";
        textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label7
        // 
        label7.BackColor = System.Drawing.Color.DarkGray;
        label7.Location = new System.Drawing.Point(460, 273);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(161, 55);
        label7.TabIndex = 24;
        label7.Text = "0";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label8
        // 
        label8.BackColor = System.Drawing.Color.DarkGray;
        label8.Location = new System.Drawing.Point(460, 375);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(161, 55);
        label8.TabIndex = 23;
        label8.Text = "0";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        AutoSize = true;
        BackColor = System.Drawing.Color.CadetBlue;
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textBox12);
        Controls.Add(textBox13);
        Controls.Add(label7);
        Controls.Add(label8);
        Controls.Add(textBox11);
        Controls.Add(textBox10);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(textBox9);
        Controls.Add(textBox8);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(textBox7);
        Controls.Add(label2);
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

    private System.Windows.Forms.TextBox textBox12;
    private System.Windows.Forms.TextBox textBox13;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox10;
    private System.Windows.Forms.TextBox textBox11;

    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.TextBox textBox9;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label2;

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