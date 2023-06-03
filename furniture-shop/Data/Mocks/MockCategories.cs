using furniture_shop.Data.Interfaces;
using furniture_shop.Data.Models;
using System.Collections.Generic;

namespace furniture_shop.Data.Mocks
{
  public class MockCategories : IFurnitureCategories
  {
    public IEnumerable<Category> AllCategories
    {
      get
      {
        return new List<Category> {
           new Category { categoryName = "Кухонні меблі", desc = "Меблі для кухні складають обідні столи та стільці" },
           new Category { categoryName = "Офісні меблі", desc = "Меблі для офісу складають стільці, суворі столи, шафи, тумби, бібліотеки, нерозкладні дивани для відвідувачів." },
        };
      }
    }
  }
}
