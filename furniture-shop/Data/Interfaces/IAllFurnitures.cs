using furniture_shop.Data.Models;
using System.Collections.Generic;

namespace furniture_shop.Data.Interfaces
{
  public interface IAllFurnitures
  {
    //функція повертає всі товари
    IEnumerable<Furniture> Furnitures { get; }
    //функція повертає всі товари у яких isFavorite = true
    IEnumerable<Furniture> getFavFurnitures { get; }
    //повертає товар за його id
    Furniture getObjectFurniture(int furnitureId);
  }
}
