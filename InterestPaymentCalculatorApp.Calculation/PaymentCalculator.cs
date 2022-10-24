using InterestPaymentCalculatorApp.Abstractions;
using InterestPaymentCalculatorApp.Calculation.Models;

namespace InterestPaymentCalculatorApp.Calculation;

public class LoanPaymentCalculator : IPaymentCalculator
{
    public List<ICalculationResult> CalculateInterestPayments(DateTime agreementDate, double sumOfLoan, double interestRate, int loanDuration)
    {
        var paymentList = new List<ICalculationResult>();
            
        var amount = sumOfLoan;
                
        var monthsAmount = loanDuration * 12;

        var monthlyRate = interestRate / 12 / 100;

        var monthPrincipalPayment  = amount / monthsAmount;

        for (var month = 1; month <= monthsAmount; month++)
        {
            var interest = amount * monthlyRate;

            var result = new LoanCalculationResult()
            {
                Month = month, 
                Date = agreementDate.AddMonths(month),
                OutstandingDebt = amount, 
                MonthlyPayment = monthPrincipalPayment,
                InterestPayment = interest
            };
            
            paymentList.Add(result);

            amount -= monthPrincipalPayment;
        }

        return paymentList;
    }
}