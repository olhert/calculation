namespace InterestPaymentCalculatorApp.Models;

public class LoanCalculationRequest
{
    public DateTime AgreementDate { get; set; }
        
    public double SumOfLoan { get; set; } // X
        
    public int LoanDuration { get; set; } // N
        
    public double InterestRate { get; set; } // R
}