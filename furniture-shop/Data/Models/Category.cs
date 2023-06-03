using System.Collections.Generic;

namespace furniture_shop.Data.Models
{
  public class Category
  {
    public int id { set; get; }
    public string categoryName { set; get; }
    public string desc { set; get; }
    public List<Furniture> furnitures { set; get; }
  }
}
