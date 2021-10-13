using System.Collections.Generic;

namespace ReadingNook.Models
{
  public class Genre
  {
    public Genre()
    {
      this.AuthorGenreJoinEntities = new HashSet<AuthorGenre>();
      this.BookGenreJoinEntities = new HashSet<BookGenre>();
      this.Subgenres = new HashSet<Subgenre>();
    }

    public int GenreId { get; set;}
    public string Name { get; set;}
    public string Description { get; set;}
    public virtual ICollection<AuthorGenre> AuthorGenreJoinEntities { get; set;}
    public virtual ICollection<BookGenre> BookGenreJoinEntities { get; set;}
    public virtual ICollection<Subgenre> Subgenres {get; set;}

  }
}