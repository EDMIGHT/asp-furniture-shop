using furniture_shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace furniture_shop.Data
{
  public class AppDBContent : DbContext
  {
    public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }
    //функція для отримання та запису всіх авто
    public DbSet<Furniture> Furniture { get; set; }
    //функція для отримання та запису всіх категорій
    public DbSet<Category> Category { get; set; }
  }
}
