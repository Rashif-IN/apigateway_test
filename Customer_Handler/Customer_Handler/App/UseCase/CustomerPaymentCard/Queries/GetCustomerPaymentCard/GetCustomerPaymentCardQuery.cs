using System;
using MediatR;

namespace cqrs_Test.Application.UseCase.CustomerPaymentCard.Queries.GetCustomerPaymentCard
{
    public class GetCustomerPaymentCardQuery : IRequest<GetCustomerPaymentCardDto>
    {
        public int Id { get; set; }
        public GetCustomerPaymentCardQuery(int id)
        {
            Id = id;
        }
    }
}
