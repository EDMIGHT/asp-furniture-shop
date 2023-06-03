using furniture_shop.Data.Interfaces;
using furniture_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace furniture_shop.Controllers
{
  public class FurnituresController : Controller
  {
    private readonly IAllFurnitures _allFurnitures;
    private readonly IFurnitureCategories _categories;

    public FurnituresController(IAllFurnitures furnitures, IFurnitureCategories category)
    {
      _allFurnitures = furnitures;
      _categories = category;
    }

    public ViewResult List()
    {
      ViewBag.Title = "Сторінка з меблями";
      //створюємо об'єкт для передачі в шаблон
      var obj = new FurnituresListViewModels();
      obj.allFurnitures = _allFurnitures.Furnitures;
      obj.currCategory = "Меблі";
      return View(obj);//передача об'єкта в шаблон
    }

  }
}
