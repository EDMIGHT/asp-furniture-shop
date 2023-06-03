using furniture_shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace furniture_shop.Data
{
  public class DBObjects
  {
    //функція для підключення до БД
    public static void Initial(AppDBContent content)
    {
      //якщо не має жодної категорії, то додаємо категорії
      if (!content.Category.Any())
      {
        content.Category.AddRange(Categories.Select(c =>
       c.Value));
      }
      //якщо не має жодного товару, то додаємо товар
      if (!content.Furniture.Any())
      {
        content.AddRange(
          new Furniture
          {
            name = "LAGKAPTEN / ALEX",
            shortDesc = "Desk, white anthracite/white",
            longDesc = "The table top’s symmetrical square pattern enhances your decor, without overwhelming it",
            img = "/img/lagkapten-desk.jpg",
            price = 190,
            isFavourite = true,
            available = true,
            Category = Categories["Кухонні меблі"],
          },
          new Furniture
          {
            name = "BESTÅ / KALLAX",
            shortDesc = "TV/storage combination, black-brown",
            longDesc = "Sometimes it's nice to have a job done for you",
            img = "/img/besta-kallax-tv-storage.jpg",
            price = 253,
            isFavourite = false,
            available = true,
            Category = Categories["Офісні меблі"],
          },
          new Furniture
          {
            name = "LAMPAN",
            shortDesc = "Table lamp, white",
            longDesc = "A classic design that fits everywhere and helps create a cosy atmosphere in the room with soft, even lighting.",
            img = "/img/lampan-table-lamp.jpg",
            price = 12,
            isFavourite = true,
            available = true,
            Category = Categories["Освітлення"]
          },
          new Furniture
          {
            name = "KLUBBSPORRE",
            shortDesc = "Rug, low pile, beige",
            longDesc = "The rug is made of pure new wool so it’s naturally soil-repellent and very durable.",
            img = "/img/klubbsporre-rug.jpg",
            price = 49,
            isFavourite = true,
            available = true,
            Category = Categories["Килими"]
          },
          new Furniture
          {
            name = "PÄRLBAND",
            shortDesc = "Duvet cover and pillowcase(s), white, gray",
            longDesc = "The densely woven cotton fabric absorbs liquids and wicks away moisture, keeping you dry and comfortable all night long.",
            img = "/img/parlband-duvet-cover.jpg",
            price = 29,
            isFavourite = true,
            available = true,
            Category = Categories["Килими"]
          },
          new Furniture
          {
            name = "BESTÅ / KALLAX",
            shortDesc = "TV/storage combination, black-brown",
            longDesc = "Sometimes it's nice to have a job done for you",
            img = "/img/parlband-duvet-cover.jpg",
            price = 29,
            isFavourite = true,
            available = true,
            Category = Categories["Освітлення"]
          },
new Furniture
{
  name = "LAGKAPTEN / ALEX",
  shortDesc = "Desk, white anthracite/white",
  longDesc = "The table top’s symmetrical square pattern enhances your decor, without overwhelming it",
  img = "/img/lampan-table-lamp.jpg",
  price = 12,
  isFavourite = true,
  available = true,
  Category = Categories["Освітлення"]
},
new Furniture
{
  name = "LAMPAN",
  shortDesc = "Table lamp, white",
  longDesc = "A classic design that fits everywhere and helps create a cosy atmosphere in the room with soft, even lighting.",
  img = "/img/besta-kallax-tv-storage.jpg",
  price = 253,
  isFavourite = false,
  available = true,
  Category = Categories["Офісні меблі"],
},
new Furniture
{
  name = "KLUBBSPORRE",
  shortDesc = "Rug, low pile, beige",
  longDesc = "The rug is made of pure new wool so it’s naturally soil-repellent and very durable.",
  img = "/img/klubbsporre-rug.jpg",
  price = 49,
  isFavourite = true,
  available = true,
  Category = Categories["Килими"]
},
new Furniture
{
  name = "PÄRLBAND",
  shortDesc = "Duvet cover and pillowcase(s), white, gray",
  longDesc = "The densely woven cotton fabric absorbs liquids and wicks away moisture, keeping you dry and comfortable all night long.",
  img = "/img/parlband-duvet-cover.jpg",
  price = 190,
  isFavourite = true,
  available = true,
  Category = Categories["Кухонні меблі"]
},
  new Furniture
  {
    name = "LAGKAPTEN / ALEX",
    shortDesc = "Desk, white anthracite/white",
    longDesc = "The table top’s symmetrical square pattern enhances your decor, without overwhelming it",
    img = "/img/lagkapten-desk.jpg",
    price = 190,
    isFavourite = true,
    available = true,
    Category = Categories["Кухонні меблі"],
  },
          new Furniture
          {
            name = "BESTÅ / KALLAX",
            shortDesc = "TV/storage combination, black-brown",
            longDesc = "Sometimes it's nice to have a job done for you",
            img = "/img/besta-kallax-tv-storage.jpg",
            price = 253,
            isFavourite = false,
            available = true,
            Category = Categories["Офісні меблі"],
          },
          new Furniture
          {
            name = "LAMPAN",
            shortDesc = "Table lamp, white",
            longDesc = "A classic design that fits everywhere and helps create a cosy atmosphere in the room with soft, even lighting.",
            img = "/img/lampan-table-lamp.jpg",
            price = 12,
            isFavourite = true,
            available = true,
            Category = Categories["Освітлення"]
          },
          new Furniture
          {
            name = "KLUBBSPORRE",
            shortDesc = "Rug, low pile, beige",
            longDesc = "The rug is made of pure new wool so it’s naturally soil-repellent and very durable.",
            img = "/img/klubbsporre-rug.jpg",
            price = 49,
            isFavourite = true,
            available = true,
            Category = Categories["Килими"]
          },
          new Furniture
          {
            name = "PÄRLBAND",
            shortDesc = "Duvet cover and pillowcase(s), white, gray",
            longDesc = "The densely woven cotton fabric absorbs liquids and wicks away moisture, keeping you dry and comfortable all night long.",
            img = "/img/parlband-duvet-cover.jpg",
            price = 29,
            isFavourite = true,
            available = true,
            Category = Categories["Килими"]
          },
          new Furniture
          {
            name = "BESTÅ / KALLAX",
            shortDesc = "TV/storage combination, black-brown",
            longDesc = "Sometimes it's nice to have a job done for you",
            img = "/img/parlband-duvet-cover.jpg",
            price = 29,
            isFavourite = true,
            available = true,
            Category = Categories["Освітлення"]
          },
new Furniture
{
  name = "LAGKAPTEN / ALEX",
  shortDesc = "Desk, white anthracite/white",
  longDesc = "The table top’s symmetrical square pattern enhances your decor, without overwhelming it",
  img = "/img/lampan-table-lamp.jpg",
  price = 12,
  isFavourite = true,
  available = true,
  Category = Categories["Освітлення"]
},
new Furniture
{
  name = "LAMPAN",
  shortDesc = "Table lamp, white",
  longDesc = "A classic design that fits everywhere and helps create a cosy atmosphere in the room with soft, even lighting.",
  img = "/img/besta-kallax-tv-storage.jpg",
  price = 253,
  isFavourite = false,
  available = true,
  Category = Categories["Офісні меблі"],
},
new Furniture
{
  name = "KLUBBSPORRE",
  shortDesc = "Rug, low pile, beige",
  longDesc = "The rug is made of pure new wool so it’s naturally soil-repellent and very durable.",
  img = "/img/klubbsporre-rug.jpg",
  price = 49,
  isFavourite = true,
  available = true,
  Category = Categories["Килими"]
},
new Furniture
{
  name = "PÄRLBAND",
  shortDesc = "Duvet cover and pillowcase(s), white, gray",
  longDesc = "The densely woven cotton fabric absorbs liquids and wicks away moisture, keeping you dry and comfortable all night long.",
  img = "/img/parlband-duvet-cover.jpg",
  price = 190,
  isFavourite = true,
  available = true,
  Category = Categories["Кухонні меблі"]
}

        );
      }
      content.SaveChanges();
    }
    private static Dictionary<string, Category> category;
    public static Dictionary<string, Category> Categories
    {
      get
      {
        if (category == null)
        {
          //створення інфомаціїї для занесення в БД
          var list = new Category[]{
            new Category { categoryName = "Кухонні меблі", desc = "Меблі для кухні складають обідні столи та стільці" },
            new Category { categoryName = "Офісні меблі", desc = "Меблі для офісу складають стільці, суворі столи, шафи, тумби, бібліотеки, нерозкладні дивани для відвідувачів." },
            new Category { categoryName = "Освітлення", desc = "категорія меблів, яка охоплює різноманітні світильники, лампи та інші пристрої, призначені для освітлення приміщень" },
            new Category { categoryName = "Килими", desc = "категорія меблів, включає в себе текстильні покриття для підлоги, що призначені для декору та комфорту" },
          }; 
          category = new Dictionary<string, Category>();
          foreach (Category el in list)
          {
            category.Add(el.categoryName, el);
          }
        }
        return category;
      }
    }
  }

}
