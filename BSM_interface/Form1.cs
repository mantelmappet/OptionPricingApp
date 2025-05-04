namespace BSM_interface;
using Black_Scholes;
public partial class Form1 : Form
{
    private double currentStockPrice = 0;
    private double timeToMaturity = 1;
    private double strikePrice = 1;
    private double riskFreeRate = 1;
    private double volatility = 1;
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
    
    private void UpdateLabel()
    {
        label1.Text = Calculator.Calculate((double)strikePrice, (double)currentStockPrice, (double)timeToMaturity, riskFreeRate/100, volatility/100).ToString();
    }

    private void numericUpDown4_ValueChanged(object sender, EventArgs e)
    {
        riskFreeRate = (double)numericUpDown4.Value;
        UpdateLabel();
    }

    private void numericUpDown5_ValueChanged(object sender, EventArgs e)
    {
        volatility = (double)numericUpDown5.Value;
        UpdateLabel();
    }
}