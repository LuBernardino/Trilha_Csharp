using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Enums;
using CashFlow.Exception;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace Validators.Test.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        // Arrange: Configure required instances for unit testing.
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();

        // Act : Run the method for the test.
        var result = validator.Validate(request);

        // Assert : The goal is to receive a result and compare it with what the test expects.
        result.IsValid.Should().BeTrue();
    }

    [Theory]
    [InlineData("")]
    [InlineData("           ")]
    [InlineData(null)]
    public void ErrorTitleEmpty(string title)
    {
        // Arrange: Configure required instances for unit testing.
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.Title = title;

        // Act : Run the method for the test.
        var result = validator.Validate(request);

        // Assert : The goal is to receive a result and compare it with what the test expects.
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.TITLE_REQUIRED));
    }

    [Fact]
    public void ErrorDateFuture()
    {
        // Arrange: Configure required instances for unit testing.
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.Date = DateTime.UtcNow.AddDays(1);

        // Act : Run the method for the test.
        var result = validator.Validate(request);

        // Assert : The goal is to receive a result and compare it with what the test expects.
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.EXPENSES_CANNOT_BE_FOR_THE_FUTURE));
    }

    [Fact]
    public void ErrorPaymentTypeInvalid()
    {
        // Arrange: Configure required instances for unit testing.
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.PaymentType = (PaymentType)700;

        // Act : Run the method for the test.
        var result = validator.Validate(request);

        // Assert : The goal is to receive a result and compare it with what the test expects.
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.PAYMENT_TYPE_IS_NOT_VALID));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-2)]
    [InlineData(-7)]
    public void ErrorAmountInvalid(decimal amount)
    {
        // Arrange: Configure required instances for unit testing.
        var validator = new RegisterExpenseValidator();
        var request = RequestRegisterExpenseJsonBuilder.Build();
        request.Amount = amount;

        // Act : Run the method for the test.
        var result = validator.Validate(request);

        // Assert : The goal is to receive a result and compare it with what the test expects.
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(e => e.ErrorMessage.Equals(ResourceErrorMessages.AMOUNT_MUST_BE_GREATER_THAN_ZARO));
    }
}
