using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Domain.Models;
using SuperMarket.Domain.Services;

namespace SuperMarket.Controllers
{
  [Route("api/[controller]")]
  public class CategoriesController : Controller
  {
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
      _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IEnumerable<Category>> GetAllAsync()
    {
      var categories = await _categoryService.ListAsync();
      return categories;
    }
  }
}