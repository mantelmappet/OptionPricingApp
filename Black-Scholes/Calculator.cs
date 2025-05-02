namespace Black_Scholes;

public class Calculator
{
    /*
    private double strikePrice;
    private double currentStockPrice;
    private double timeToExpiration;
    private double riskFreeRate;
    private double volatility;

    public Calculator(double strikePrice, double currentStockPrice, double timeToExpiration, double riskFreeRate,
        double volatility)
    {
        this.strikePrice = strikePrice;
        this.currentStockPrice = currentStockPrice;
        this.timeToExpiration = timeToExpiration;
        this.riskFreeRate = riskFreeRate;
        this.volatility = volatility;
    }
    */
    public static double Calculate(double strikePrice, double currentStockPrice, double timeToExpiration, double riskFreeRate,
        double volatility)
    {
        double d1 = Math.Log(currentStockPrice / strikePrice) + (riskFreeRate + 0.5 * Math.Pow(volatility, 2)*timeToExpiration) / (volatility*Math.Sqrt(timeToExpiration));
        double d2 = d1 - (volatility * Math.Sqrt(timeToExpiration));
        double N1 = CumulativeDistributionFunction.CDF(d1); 
        double N2 = CumulativeDistributionFunction.CDF(d2);
        return currentStockPrice * N1 - strikePrice * Math.Exp(-1*riskFreeRate*timeToExpiration)*N2;
    }
}