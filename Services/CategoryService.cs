using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarket.Domain.Models;
using SuperMarket.Domain.Repositories;
using SuperMarket.Domain.Services;

namespace SuperMarket.Services
{
  public class CategoryService : ICategoryService
  {
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
      this._categoryRepository = categoryRepository;
    }

    public async Task<IEnumerable<Category>> ListAsync()
    {
      return await _categoryRepository.ListAsync();
    }
  }
}