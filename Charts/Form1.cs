using System;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.WinForms;
using Color = System.Drawing.Color;

namespace Charts
{
    public partial class Form1 : Form
    {
        public Form1(string[] myValues)
        {
            InitializeComponent();

            FormsPlot  formsPlot = new FormsPlot()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(formsPlot);
            double[] spotPrices = PriceCounterSpotPrices(myValues);
            double[] bsPrices = PriceCounterbsPrices(myValues);
            double[] mcPrices = PriceCountermcPrices(myValues);

            formsPlot.Plot.Add.Scatter(spotPrices, bsPrices);
            formsPlot.Plot.Add.Scatter(spotPrices, mcPrices);
            formsPlot.Plot.Title("Option Prices vs Spot Price");
            formsPlot.Plot.XLabel("Current Stock Price");
            formsPlot.Plot.YLabel("Counted Stock Price");


            formsPlot.Refresh();
        }

        public double[] PriceCounterSpotPrices(string[] myValues)
        {
            List<double> asd = new List<double>();
            for (int i = 0; i < 200; ++i)
            {
                asd.Add(Convert.ToDouble(myValues[0]) + i);
            }
            return asd.ToArray();
        }

        public double[] PriceCounterbsPrices(string[] myValues)
        {
            List<double> asd = new List<double>();
            for (int i = 0; i < 200; ++i)
            {
                asd.Add(BlackScholes.Calculator.Calculate(Convert.ToDouble(myValues[1]), Convert.ToDouble(myValues[0])+i,Convert.ToDouble(myValues[2]),Convert.ToDouble(myValues[3])/100,Convert.ToDouble(myValues[4])/100));
            }
            return asd.ToArray();
        }
        public double[] PriceCountermcPrices(string[] myValues)
        {
            List<double> asd = new List<double>();
            for (int i = 0; i < 200; ++i)
            {
                asd.Add(MonteCarloSim.Calculator.CalcEurpeanCall(Convert.ToDouble(myValues[1]), Convert.ToDouble(myValues[0])+i,Convert.ToDouble(myValues[2]),Convert.ToDouble(myValues[3])/100,Convert.ToDouble(myValues[4])/100));
            }
            return asd.ToArray();
        }
    }
}