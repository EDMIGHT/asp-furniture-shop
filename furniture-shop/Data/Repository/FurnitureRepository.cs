using furniture_shop.Data.Interfaces;
using furniture_shop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace furniture_shop.Data.Repository
{
  public class FurnitureRepository: IAllFurnitures
  {
    //змінна для роботи з класом налаштувань БД AppDBContext.cs
    private readonly AppDBContent appDBContent;
    public FurnitureRepository(AppDBContent appDBContent)
    {
      this.appDBContent = appDBContent;
    }
    public IEnumerable<Furniture> Furnitures => appDBContent.Furniture.Include(c =>
   c.Category);
    public IEnumerable<Furniture> getFavFurnitures => appDBContent.Furniture.Where(p
   => p.isFavourite).Include(c => c.Category);
    public Furniture getObjectFurniture(int carId) =>
   appDBContent.Furniture.FirstOrDefault(p => p.id == carId);
  }
}
