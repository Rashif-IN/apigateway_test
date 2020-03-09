using System;
using cqrs_Test.Application.Models.Query;
using cqrs_Test.Domain.Entities;
using MediatR;

namespace cqrs_Test.Application.UseCase.Merchant.Command.PostMerchant
{
    public class PostMerchantCommand : RequestData<Merchants>, IRequest<PostMerchantCommandDto>
    {
    }
   
}
