namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}