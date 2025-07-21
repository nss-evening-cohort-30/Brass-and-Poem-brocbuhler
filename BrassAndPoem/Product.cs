//create your Product class here
public class Product
{
  public string Name { get; set; }
  public decimal Price { get; set; }
  public int ProductTypeId { get; set; }
  public int DR
  {
    get { return DR; }
    set
    {
      if (new[] { 4, 6, 8, 10, 12, 20 }.Contains(value))
      {
        DR = value;
      }
      else
      {
        throw new ArgumentOutOfRangeException(nameof(value), "Dice may only be 4, 6, 8, 10, 12, or 20 sided");
      }
    }
  }
}
