using furniture_shop.Data.Models;
using System.Collections.Generic;

namespace furniture_shop.Data.Interfaces
{
  public interface IFurnitureCategories
  {
    IEnumerable<Category> AllCategories { get; }
  }
}
