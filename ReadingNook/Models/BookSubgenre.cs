namespace ReadingNook.Models
{
  public class BookSubgenre
  {
    public int BookSubgenreId { get; set;}
    public int BookId { get; set;}
    public int SubgenreId { get; set;}
    public virtual Book Book { get; set;}
    public virtual Subgenre Subgenre { get; set;}
  }
}