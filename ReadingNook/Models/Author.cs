using System.Collections.Generic;

namespace ReadingNook.Models
{
  public class Author
  {
    public Author()
    {
      this.AuthorBookJoinEntities = new HashSet<AuthorBook>();
      this.AuthorGenreJoinEntities = new HashSet<AuthorGenre>();
      this.AuthorSubGenreJoinEntities = new HashSet<AuthorGenre>();
    }

    public int AuthorId { get; set;}
    public string Name { get; set;}
    public string Description { get; set;}
    public int DOB { get; set;}
    public virtual ICollection <AuthorBook> AuthorBookJoinEntities { get; set;}
    public virtual ICollection <AuthorGenre> AuthorGenreJoinEntities { get; set;}
    public virtual ICollection <AuthorSubgenre> AuthorSubgenreJoinEntities { get; set;}
  }
}