using System.Collections.Generic;

namespace ReadingNook.Models
{
  public class Readlist
  {
    public Readlist()
    {
      this.BookReadlistJoinEntities = new HashSet<BookReadlist>();
    }

    public int ReadlistId { get; set;}
    public string Name { get; set;}
    public string Description { get; set;}
    public virtual ICollection<BookReadlist> BookReadlistJoinEntities { get; set;}
  }
}