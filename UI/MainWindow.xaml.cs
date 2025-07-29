using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MonteCarloSim;
using BlackScholes;

namespace UI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, RoutedEventArgs e)
    {
        if (!double.TryParse(SpotPriceTextBox.Text, out double S) ||
            !double.TryParse(StrikePriceTextBox.Text, out double K) ||
            !double.TryParse(TimeToMaturityTextBox.Text, out double T) ||
            !double.TryParse(VolatilityTextBox.Text, out double sigma) ||
            !double.TryParse(RiskFreeRateTextBox.Text, out double r))
        {
            return;
        }

        double bsCall = BlackScholes.Calculator.Calculate(K, S, T, r/100, sigma/100);
        double bsPut = BlackScholes.Calculator.CalculatePut(K, S, T, r / 100, sigma / 100);
        double mcCall = MonteCarloSim.Calculator.CalcEurpeanCall(K, S, T, r / 100, sigma / 100);
        double mcPut = MonteCarloSim.Calculator.CalcEurpeanPut(K, S, T, r / 100, sigma / 100);

        double absDiff = Math.Abs(bsCall - mcCall);
        double percDiff = bsCall != 0 ? absDiff / bsCall * 100 : 0;

        BSCPriceTextBlock.Text = bsCall.ToString("F4");
        BSPPriceTextBlock.Text = bsPut.ToString("F4");
        MCCPriceTextBlock.Text = mcCall.ToString("F4");
        MCPPriceTextBlock.Text = mcPut.ToString("F4");
        AbsDiffTextBlock.Text = absDiff.ToString("F4");
        PercDiffTextBlock.Text = percDiff.ToString("F2") + " %";
    }   

}