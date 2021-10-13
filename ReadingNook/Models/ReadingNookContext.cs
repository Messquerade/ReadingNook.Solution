using Microsoft.EntityFrameworkCore;

namespace ReadingNook.Models
{
  public class ReadingNookContext : DbContext
  {
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Readlist> Readlists { get; set; }
    public DbSet<Genre> Genres { get; set;}
    public DbSet<Subgenre> Subgenres { get; set; }
    public DbSet<AuthorBook> AuthorBook { get; set; }
    public DbSet<AuthorGenre> AuthorGenre { get; set;}
    public DbSet<AuthorSubgenre> AuthorSubgenre { get; set; }
    public DbSet<BookGenre> BookGenre { get; set; }
    public DbSet<BookSubgenre> BookSubgenre { get; set; }
    public DbSet<BookReadlist> BookReadlist { get; set; }

    public ReadingNookContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

  }
}