namespace BlackScholes;

public class Calculator
{
    public static double Calculate(double strikePrice, double currentStockPrice, double timeToExpiration, double riskFreeRate,
        double volatility)
    {
        double d1 = Math.Log(currentStockPrice / strikePrice) + (riskFreeRate + 0.5 * Math.Pow(volatility, 2)*timeToExpiration) / (volatility*Math.Sqrt(timeToExpiration));
        double d2 = d1 - (volatility * Math.Sqrt(timeToExpiration));
        double N1 = CumulativeDistributionFunction.CDF(d1); 
        double N2 = CumulativeDistributionFunction.CDF(d2);
        return currentStockPrice * N1 - strikePrice * Math.Exp(-1*riskFreeRate*timeToExpiration)*N2;
    }
    public static double CalculatePut(double strikePrice, double currentStockPrice, double timeToExpiration, double riskFreeRate,
        double volatility)
    {
        double d1 = (Math.Log(currentStockPrice / strikePrice) + (riskFreeRate + 0.5 * Math.Pow(volatility, 2)) * timeToExpiration) / (volatility * Math.Sqrt(timeToExpiration));
        double d2 = d1 - (volatility * Math.Sqrt(timeToExpiration));
        double N1 = CumulativeDistributionFunction.CDF(d1*-1); 
        double N2 = CumulativeDistributionFunction.CDF(d2*-1);
        return strikePrice * Math.Exp(-1*riskFreeRate*timeToExpiration)*N2-currentStockPrice * N1;
    }
}