using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("✅ Running Financial Forecast Program...");

            double presentValue = 10000;
            double growthRate = 0.07;
            int years = 5;

            double recursive = Forecast.PredictFutureValue(presentValue, growthRate, years);
            double optimized = Forecast.PredictFutureValueOptimized(presentValue, growthRate, years);

            Console.WriteLine($"🔁 Recursive Forecast: ₹{recursive:F2}");
            Console.WriteLine($"⚡ Optimized Forecast: ₹{optimized:F2}");
        }
    }
}
