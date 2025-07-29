namespace BSM_interface;
using BlackScholes;
using MonteCarloSim;
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
    private void UpdateLabel()
    {
        double bsCall = BlackScholes.Calculator.Calculate(strikePrice, currentStockPrice, timeToMaturity,
            riskFreeRate / 100, volatility / 100);
        double bsPut = BlackScholes.Calculator.CalculatePut(strikePrice, currentStockPrice, timeToMaturity,
            riskFreeRate / 100, volatility / 100);
        double mcCall = MonteCarloSim.Calculator.CalcEurpeanCall(strikePrice, currentStockPrice, timeToMaturity,
            riskFreeRate / 100, volatility / 100);
        double mcPut = MonteCarloSim.Calculator.CalcEurpeanPut(strikePrice, currentStockPrice, timeToMaturity,
            riskFreeRate / 100, volatility / 100);
        double AbsolutDiffCall = Math.Abs(bsCall-mcCall);
        double AbsolutDiffPut = Math.Abs(bsPut-mcPut);
        double DifferenceCall = 100 * ((mcCall - bsCall) / bsCall);
        double DifferencePut = 100 * ((mcPut - bsPut) / bsPut);
        label1.Text = bsCall.ToString();
        label2.Text = bsPut.ToString();
        label3.Text = mcCall.ToString();
        label4.Text = mcPut.ToString();
        label5.Text = AbsolutDiffCall.ToString();
        label6.Text = DifferenceCall.ToString();
        label7.Text = AbsolutDiffPut.ToString();
        label8.Text = DifferencePut.ToString();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void label3_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}