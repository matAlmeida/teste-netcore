using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarket.Domain.Models;

namespace SuperMarket.Domain.Services
{
  public interface ICategoryService
  {
    Task<IEnumerable<Category>> ListAsync();
  }
}