using CQRS.Commands.Response;
using MediatR;

namespace CQRS.Commands.Request
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name {get; set;}
        public string Email {get; set;}
    }
}