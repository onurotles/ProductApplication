using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApplication.Application.Interfaces.Repository;
using ProductApplication.Persistence.Context;
using ProductApplication.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
