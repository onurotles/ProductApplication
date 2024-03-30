using AutoMapper;
using MediatR;
using ProductApplication.Application.Interfaces.Repository;
using ProductApplication.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Application.Features.Queries.GetAllProductsQuery
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<List<GetAllProductsViewModel>>>
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public GetAllProductsHandler(IMapper mapper, IProductRepository productRepository)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
        }

        public async Task<ServiceResponse<List<GetAllProductsViewModel>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var results = await productRepository.GetAllAsync();
            var mappedResult = mapper.Map<List<GetAllProductsViewModel>>(results);
            return new ServiceResponse<List<GetAllProductsViewModel>>(mappedResult);
        }
    }
}
