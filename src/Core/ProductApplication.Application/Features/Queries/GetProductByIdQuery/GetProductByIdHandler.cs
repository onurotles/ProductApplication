using AutoMapper;
using MediatR;
using ProductApplication.Application.Interfaces.Repository;
using ProductApplication.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Application.Features.Queries.GetProductByIdQuery
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public GetProductByIdHandler(IMapper mapper, IProductRepository productRepository)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
        }

        public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await productRepository.GetByIdAsync(request.Id);
            var mappedResult = mapper.Map<GetProductByIdViewModel>(result);
            return new ServiceResponse<GetProductByIdViewModel>(mappedResult);
        }
    }
}
