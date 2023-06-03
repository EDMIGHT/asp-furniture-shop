using furniture_shop.Data.Interfaces;
using furniture_shop.Data.Models;
using System.Collections.Generic;

namespace furniture_shop.Data.Repository
{
  public class CategoryRepository : IFurnitureCategories
  {
    private readonly AppDBContent appDBContent;
    public CategoryRepository(AppDBContent appDBContent)
    {
      this.appDBContent = appDBContent;
    }
    public IEnumerable<Category> AllCategories =>
   appDBContent.Category;
  }

}
