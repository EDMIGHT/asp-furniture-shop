using furniture_shop.Data.Models;
using System.Collections.Generic;
using System;
using furniture_shop.Data.Interfaces;
using System.Linq;

namespace furniture_shop.Data.Mocks
{
  public class MockFurnitures: IAllFurnitures
  {
    private readonly IFurnitureCategories _categoryFurnitures = new MockCategories();

    public IEnumerable<Furniture> Furnitures
    {
      get
      {
        return new List<Furniture> {
          new Furniture {
            name = "LAGKAPTEN / ALEX",
            shortDesc = "Desk, white anthracite/white",
            longDesc="The table top’s symmetrical square pattern enhances your decor, without overwhelming it",
            img="/img/lagkapten-desk.jpg",
            price=190,
            isFavourite=true,
            available=true,
            Category = _categoryFurnitures.AllCategories.First()
          },
          new Furniture {
            name = "BESTÅ / KALLAX",
            shortDesc = "TV/storage combination, black-brown",
            longDesc = "Sometimes it's nice to have a job done for you",
            img = "/img/besta-kallax-tv-storage.jpg",
            price = 253,
            isFavourite = false,
            available = true,
            Category = _categoryFurnitures.AllCategories.Last()
          }
        };
      }
    }

    public IEnumerable<Furniture> getFavFurnitures { get; set; }

    public Furniture getObjectFurniture(int furnitureId)
    {
      throw new NotImplementedException();
    }
  }
}
