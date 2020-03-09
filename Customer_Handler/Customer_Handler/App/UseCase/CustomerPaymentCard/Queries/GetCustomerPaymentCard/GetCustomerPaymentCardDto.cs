using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;

namespace cqrs_Test.Application.UseCase.CustomerPaymentCard.Queries.GetCustomerPaymentCard
{
    public class GetCustomerPaymentCardDto : BaseDto
    {
        public CustomerPaymentCards Data { get; set; }
    }
}
