using furniture_shop.Data.Models;
using System.Collections.Generic;

namespace furniture_shop.ViewModels
{
  public class FurnituresListViewModels
  {
    //поле, що збергіає всі товари
    public IEnumerable<Furniture> allFurnitures { get; set; }
    //зберігає поточну категорію
    public string currCategory { get; set; }
  }
}
