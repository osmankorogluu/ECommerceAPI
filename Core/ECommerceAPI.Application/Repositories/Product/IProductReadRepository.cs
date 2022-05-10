using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ECommerceAPI.Domain.Entities;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    public interface IProductReadRepository : IReadRepository<Product>
    {
    }
}
