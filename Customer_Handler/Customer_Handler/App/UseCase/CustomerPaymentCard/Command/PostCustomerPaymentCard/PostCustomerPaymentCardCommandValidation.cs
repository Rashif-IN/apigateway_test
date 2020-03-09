using System;
using cqrs_Test.Application.Models.Query;
using FluentValidation;

namespace cqrs_Test.Application.UseCase.CustomerPaymentCard.Command.PostCustomerPaymentCard
{
    public class PostCustomerPaymentCardCommandValidation : AbstractValidator<PostCustomerPaymentCardCommand>
    {
        public PostCustomerPaymentCardCommandValidation()
        {
            RuleFor(x => x.Dataa.Attributes.name_on_card).NotEmpty().WithMessage("name_on_card can't be empty");
            RuleFor(x => x.Dataa.Attributes.name_on_card).MaximumLength(50).WithMessage("max name lenght is 50");
            RuleFor(x => x.Dataa.Attributes.exp_month).NotEmpty().WithMessage("exp_month can't be empty");
            RuleFor(x => Convert.ToInt32(x.Dataa.Attributes.exp_month)).ExclusiveBetween(1, 12).WithMessage("exp_month is bettween 1-12");
            RuleFor(x => x.Dataa.Attributes.exp_year).NotEmpty().WithMessage("exp_year can't be empty");
            RuleFor(x => x.Dataa.Attributes.credit_card_number).CreditCard().WithMessage("credit_card_number must be type of credit card number");
        }
    }
}
