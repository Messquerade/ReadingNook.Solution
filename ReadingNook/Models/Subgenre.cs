using System.Collections.Generic;

namespace ReadingNook.Models
{
  public class Subgenre
  {
    public Subgenre()
    {
      this.AuthorSubgenreJoinEntities = new HashSet<AuthorSubgenre>();
      this.BookSubgenreJoinEntities = new HashSet<BookSubgenre>();
    }

    public int SubgenreId { get; set;}
    public string Name { get; set;}
    public string Description { get; set;}
    public int GenreId { get; set;}
    public virtual Genre Genre { get; set;}
    public virtual ICollection<AuthorSubgenre> AuthorSubgenreJoinEntities { get; set;}
    public virtual ICollection<BookSubgenre> BookSubgenreJoinEntities { get; set;}
  }
}