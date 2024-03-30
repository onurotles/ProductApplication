using MediatR;
using ProductApplication.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Application.Features.Commands.CreateProductCommand
{
    public class CreateProductCommand : IRequest<ServiceResponse<CreateProductViewModel>>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
