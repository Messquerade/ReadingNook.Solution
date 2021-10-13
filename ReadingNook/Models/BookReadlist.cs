namespace ReadingNook.Models
{
  public class BookReadlist
  {
    public int BookReadlistId { get; set;}
    public int BookId { get; set;}
    public int ReadlistId { get; set;}
    public virtual Book Book { get; set;}
    public virtual Readlist Readlist { get; set;}
  }
}