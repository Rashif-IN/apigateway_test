using System;
using cqrs_Test.Application.UseCase.CustomerPaymentCard.Queries.GetCustomerPaymentCard;
using MediatR;

namespace cqrs_Test.Application.UseCase.CustomerPaymentCard.Queries.GetCustomerPaymentCards
{
    public class GetCustomerPaymentCardsQuery : IRequest<GetCustomerPaymentCardsDto>
    {
    }
}
