using AutoMapper;
using MediatR;
using ProductApplication.Application.Interfaces.Repository;
using ProductApplication.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Application.Features.Commands.CreateProductCommand
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ServiceResponse<CreateProductViewModel>>
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;

        public CreateProductHandler(IMapper mapper, IProductRepository productRepository)
        {
            this.mapper = mapper;
            this.productRepository = productRepository;
        }

        public async Task<ServiceResponse<CreateProductViewModel>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var mappedRequest = mapper.Map<Domain.Entities.Product>(request);
            var result = await productRepository.AddAsync(mappedRequest);
            var mappedResponse = mapper.Map<CreateProductViewModel>(result);
            return new ServiceResponse<CreateProductViewModel>(mappedResponse);
        }
    }
}
