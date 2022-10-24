using InterestPaymentCalculatorApp.Abstractions;

namespace InterestPaymentCalculatorApp.Calculation.Models;

public class LoanCalculationResult : ICalculationResult
{
    public int Month { get; set; }
    public DateTime Date { get; set; }
    public double OutstandingDebt { get; set; }
    public double MonthlyPayment { get; set; }
    public double InterestPayment { get; set; }
}