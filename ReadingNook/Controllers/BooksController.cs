using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReadingNook.Models;
using System.Collections.Generic;
using System.Linq;

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
  }
}