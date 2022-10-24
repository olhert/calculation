namespace InterestPaymentCalculatorApp.Abstractions;

public interface IPaymentCalculator
{
    List<ICalculationResult> CalculateInterestPayments(DateTime agreementDate, double sumOfLoan, double interestRate, int loanDuration);
}