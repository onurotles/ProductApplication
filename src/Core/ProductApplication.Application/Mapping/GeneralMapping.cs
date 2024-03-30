using AutoMapper;
using ProductApplication.Application.Features.Commands.CreateProductCommand;
using ProductApplication.Application.Features.Queries.GetAllProductsQuery;
using ProductApplication.Application.Features.Queries.GetProductByIdQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Product, GetAllProductsViewModel>()
                .ReverseMap();
            CreateMap<Domain.Entities.Product, GetProductByIdViewModel>()
                .ReverseMap();
            CreateMap<Domain.Entities.Product, CreateProductCommand>()
                .ReverseMap();
            CreateMap<Domain.Entities.Product, CreateProductViewModel>()
                .ReverseMap();
        }
    }
}
