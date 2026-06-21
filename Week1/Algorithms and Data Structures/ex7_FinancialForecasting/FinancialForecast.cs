using System;

public class FinancialForecast
{
    // Time Complexity: O(n)
    // Space Complexity: O(n) due to recursion stack

    public static double PredictFutureValue(
        double currentValue,
        double growthRate,
        int years)
    {
        // Base Case - O(1)
        if (years == 0)
        {
            return currentValue;
        }

        // Recursive Call - O(n)
        return PredictFutureValue(
            currentValue * (1 + growthRate),
            growthRate,
            years - 1);
    }
}