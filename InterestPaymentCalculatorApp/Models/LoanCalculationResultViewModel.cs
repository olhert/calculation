using InterestPaymentCalculatorApp.Abstractions;

namespace InterestPaymentCalculatorApp.Models;

public class LoanCalculationResultViewModel : ICalculationResult
{
    public int Month { get; set; }
    public DateTime Date { get; set; }
    public double OutstandingDebt { get; set; }
    public double MonthlyPayment { get; set; }
    public double InterestPayment { get; set; }

    public static LoanCalculationResultViewModel Create(ICalculationResult src)
    {
        return new LoanCalculationResultViewModel
        {
            Month = src.Month,
            Date = src.Date,
            OutstandingDebt = src.OutstandingDebt,
            MonthlyPayment = src.MonthlyPayment,
            InterestPayment = src.InterestPayment,
        };
    }
}