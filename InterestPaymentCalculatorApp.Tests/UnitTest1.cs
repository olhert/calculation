using InterestPaymentCalculatorApp.Calculation;

namespace InterestPaymentCalculatorApp.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        var result = new LoanPaymentCalculator().CalculateInterestPayments(DateTime.UtcNow, 2500,25, 1);
        
        Assert.That(result.All(itm => Math.Round(itm.MonthlyPayment, 2) == 208.33), Is.EqualTo(true));
       
        Assert.That(Math.Round(result[0].InterestPayment, 2), Is.EqualTo(52.08)); 
        Assert.That(Math.Round(result[4].InterestPayment, 2), Is.EqualTo(34.72));
        Assert.That(Math.Round(result[9].InterestPayment, 2), Is.EqualTo(13.02));
        
        Assert.That(Math.Round(result[3].OutstandingDebt, 2), Is.EqualTo(1875));
        Assert.That(Math.Round(result[6].OutstandingDebt, 2), Is.EqualTo(1250));
        Assert.That(Math.Round(result[9].OutstandingDebt, 2), Is.EqualTo(625));
    }
    
    
}