using MediatR;
using ProductApplication.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Application.Features.Queries.GetProductByIdQuery
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
