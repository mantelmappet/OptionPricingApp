namespace MonteCarloSim;

public class Calculator
{
    private static Random  rand = new Random();
    private static double SampleStandardNormal() // get random number between 0 and 1 using Box-Muller transform
    {
        double u1 = 1.0 - rand.NextDouble(); 
        double u2 = 1.0 - rand.NextDouble();
        return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
    }
    public static double CalcEurpeanCall(double strikePrice, double currentStockPrice, double timeToExpiration, double riskFreeRate,
        double volatility)
    {
        int numSimulations = 100000;
        double resultSum = 0.0;
        for (int i = 0; i < numSimulations; ++i)
        {
            double z = SampleStandardNormal();
            double result = currentStockPrice * Math.Exp((riskFreeRate - 0.5 * volatility * volatility) * timeToExpiration +
                     volatility * Math.Sqrt(timeToExpiration)*z);
            double actualResult = Math.Max(result-strikePrice, 0.0);
            resultSum = resultSum + actualResult;
        } 
        //implementation of the mathematical formula for the present value of the expected payoff under risk-neutral valuation
        return Math.Exp(-riskFreeRate * timeToExpiration) * (resultSum / numSimulations);
    }
    public static double CalcEurpeanPut(double strikePrice, double currentStockPrice, double timeToExpiration, double riskFreeRate,
        double volatility)
    {
        int numSimulations = 100000;
        double resultSum = 0.0;
        for (int i = 0; i < numSimulations; ++i)
        {
            double z = SampleStandardNormal();
            double result = currentStockPrice * Math.Exp((riskFreeRate - 0.5 * volatility * volatility) * timeToExpiration +
                                                         volatility * Math.Sqrt(timeToExpiration)*z);
            double actualResult = Math.Max(strikePrice-result, 0.0);
            resultSum = resultSum + actualResult;
        } 
        return Math.Exp(-riskFreeRate * timeToExpiration) * (resultSum / numSimulations);
    }
}