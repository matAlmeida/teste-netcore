using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarket.Domain.Models;

namespace SuperMarket.Domain.Repositories
{
  public interface ICategoryRepository
  {
    Task<IEnumerable<Category>> ListAsync();
  }
}