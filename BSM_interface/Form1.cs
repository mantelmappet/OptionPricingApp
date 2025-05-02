namespace BSM_interface;
using Black_Scholes;
public partial class Form1 : Form
{
    private double currentStockPrice = 0;
    private double timeToMaturity = 1;
    private double strikePrice = 1;
    public Form1()
    {
        InitializeComponent();
    }

    public void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        currentStockPrice = (double)numericUpDown1.Value;
        UpdateLabel();
    }

    private void numericUpDown2_ValueChanged(object sender, EventArgs e)
    {
        timeToMaturity = (double)numericUpDown2.Value;
        UpdateLabel();
    }

    private void numericUpDown3_ValueChanged(object sender, EventArgs e)
    {
        strikePrice = (double)numericUpDown3.Value;
        UpdateLabel();
    }


    private void label1_Click(object sender, EventArgs e)
    {
        label1.Text = Calculator.Calculate(strikePrice, currentStockPrice, timeToMaturity, 1, 1).ToString();
    }
    private void UpdateLabel()
    {
        label1.Text = Calculator.Calculate((double)strikePrice, (double)currentStockPrice, (double)timeToMaturity, 1, 1).ToString();
    }
}