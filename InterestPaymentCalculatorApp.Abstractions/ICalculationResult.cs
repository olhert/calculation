namespace InterestPaymentCalculatorApp.Abstractions;

public interface ICalculationResult
{
    int Month { get; }
    DateTime Date { get; }
    double OutstandingDebt { get; }
    double MonthlyPayment { get; }
    double InterestPayment { get; }
}