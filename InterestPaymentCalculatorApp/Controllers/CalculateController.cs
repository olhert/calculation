using InterestPaymentCalculatorApp.Abstractions;
using InterestPaymentCalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterestPaymentCalculatorApp.Controllers;

public class CalculateController : Controller
{
    private readonly IPaymentCalculator _calculator;

    public CalculateController(IPaymentCalculator calculator)
    {
        _calculator = calculator;
    }

    [HttpGet("/")]
    public IActionResult Payments()
    {
        return View();
    }

    [HttpGet("paymentsResult")]
    public IActionResult PaymentsResult(LoanCalculationRequest request)
    {
        var data = _calculator
            .CalculateInterestPayments(request.AgreementDate, request.SumOfLoan, request.InterestRate, request.LoanDuration);
        ViewBag.Payments = data.Select(LoanCalculationResultViewModel.Create);

        return View();
    }
}