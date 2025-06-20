using System;

namespace FinancialForecasting
{
    public class Forecast
    {
        public static double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return PredictFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }

        public static double PredictFutureValueOptimized(double currentValue, double growthRate, int years)
        {
            return currentValue * Math.Pow(1 + growthRate, years);
        }
    }
}
