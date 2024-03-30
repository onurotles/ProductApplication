using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Application.Wrappers
{
    public class ServiceResponse<T>
    {
        public T Entity { get; set; }

        public ServiceResponse(T entity)
        {
            Entity = entity;
        }

        public ServiceResponse()
        {
            
        }
    }
}
