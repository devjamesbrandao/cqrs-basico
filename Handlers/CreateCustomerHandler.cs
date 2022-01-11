using System;
using System.Threading;
using System.Threading.Tasks;
using CQRS.Commands.Request;
using CQRS.Commands.Response;
using MediatR;

namespace CQRS.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    { 
        public Task<CreateCustomerResponse> Handle(
            CreateCustomerRequest request, 
            CancellationToken cancellationToken
        )
        {
            var resposta = new CreateCustomerResponse
            {
                Date = DateTime.Now,
                Email = "teste@gmail.com",
                Id = Guid.NewGuid(),
                Name = "CQRS"
            };

            return Task.FromResult(resposta);
        }
    }
}