namespace ReadingNook.Models
{
  public class AuthorSubgenre
  {
    public int AuthorSubgenreId { get; set;}
    public int AuthorId { get; set;}
    public int SubgenreId { get; set;}
    public virtual Author Author { get; set;}
    public virtual Subgenre Subgenre { get; set;}
  }
}