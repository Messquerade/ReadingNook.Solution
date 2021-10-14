using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReadingNook.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ReadingNook.Controllers
{
  public class BooksController : Controller
  {
    private readonly ReadingNookContext _db;

    public BooksController(ReadingNookContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Books.OrderBy(book => book.Title).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Book book)
    {
      _db.Books.Add(book);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisBook = _db.Books
        .Include(book => book.AuthorBookJoinEntities)
        .ThenInclude(join => join.Author)
        .Include(book => book.BookReadlistJoinEntities)
        .ThenInclude(join => join.Readlist)
        .Include(book => book.BookGenreJoinEntities)
        .ThenInclude(join => join.Genre)
        .Include(book => book.BookSubgenreJoinEntities)
        .ThenInclude(join => join.Subgenre)
        .FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    public ActionResult Edit(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    [HttpPost]
    public ActionResult Edit(Book book)
    {
      _db.Entry(book).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = book.BookId});
    }

    public ActionResult Delete(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      _db.Books.Remove(thisBook);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult ChooseRandom()
    {
      Random rand = new Random();
      List<Book> books = _db.Books.ToList();
      List<int> bookIds = new List<int>();
      foreach(Book book in books)
      {
        bookIds.Add(book.BookId);
      }
      int randomIndex = rand.Next(0, bookIds.Count);
      int randomId = bookIds[randomIndex];
      return RedirectToAction("Details", new { id = randomId});
    }




  }
}