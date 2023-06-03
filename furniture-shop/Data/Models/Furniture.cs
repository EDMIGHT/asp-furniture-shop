namespace furniture_shop.Data.Models
{
  public class Furniture
  {
    public int id { set; get; }
    public string name { set; get; }
    public string shortDesc { set; get; }
    public string longDesc { set; get; }
    public string img { set; get; }
    public ushort price { set; get; }
    public bool isFavourite { set; get; }
    public bool available { set; get; }
    public int categoryID { set; get; } //категорія товару
    public virtual Category Category { set; get; } //об'єкт, що містить всю інформацію про категорію
  }
}
