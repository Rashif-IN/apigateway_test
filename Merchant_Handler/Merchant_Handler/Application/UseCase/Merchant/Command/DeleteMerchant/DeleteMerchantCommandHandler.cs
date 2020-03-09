﻿using System;
using System.Threading;
using System.Threading.Tasks;
using cqrs_Test.Application.Interfaces;

using MediatR;

namespace cqrs_Test.Application.UseCase.Merchant.Command.DeleteMerchant
{
    public class DeleteMerchantCommandHandler : IRequestHandler<DeleteMerchantCommand, DeleteMerchantCommandDto>
    {
        private readonly IContext konteks;

        public DeleteMerchantCommandHandler(IContext context)
        {
            konteks = context;
        }
        

        public async Task<DeleteMerchantCommandDto> Handle(DeleteMerchantCommand request, CancellationToken cancellationToken)
        {
            var data = await konteks.merhcants.FindAsync(request.Id);
            if (data == null)
            {
                
                return new DeleteMerchantCommandDto
                {
                    Message = "Merchant not found",
                    Status = false
                };
            }
            else
            {
                konteks.merhcants.Remove(data);
                await konteks.SaveChangesAsync(cancellationToken);
               
                return new DeleteMerchantCommandDto
                {
                    Status = true,
                    Message = "Merchant sucessfully removed"
                };
            }
            throw new NotImplementedException();
        }
    }
}
