using System.Collections.Generic;

namespace ReadingNook.Models
{
  public class Book
  {
    public Book()
    {
      this.AuthorBookJoinEntities = new HashSet<AuthorBook>();
      this.BookGenreJoinEntities = new HashSet<BookGenre>();
      this.BookSubgenreJoinEntities = new HashSet<BookSubgenre>();
      this.BookReadlistJoinEntities = new HashSet<BookReadlist>();
    }

    public int BookId { get; set;}
    public string Title { get; set;}
    public string Description { get; set;}
    public int Length { get; set;}
    public bool Read { get; set;}
    public string Series { get; set;}
    public int Publication { get; set;}
    public string Tags { get; set;}
    public virtual ICollection <AuthorBook> AuthorBookJoinEntities { get; set;}
    public virtual ICollection <BookGenre> BookGenreJoinEntities { get; set;}
    public virtual ICollection <BookSubgenre> BookSubgenreJoinEntities { get; set;}
    public virtual ICollection <BookReadlist> BookReadlistJoinEntities { get; set;}
  }
}