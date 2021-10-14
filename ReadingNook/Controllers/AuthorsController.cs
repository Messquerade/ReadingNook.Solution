using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReadingNook.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ReadingNook.Controllers
{
  public class AuthorsController : Controller
  {
    private readonly ReadingNookContext _db;

    public AuthorsController(ReadingNookContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Authors.OrderBy(author => author.Name).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Author author)
    {
      _db.Authors.Add(author);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisauthor = _db.Authors
        .Include(author => author.AuthorBookJoinEntities)
        .ThenInclude(join => join.Book)
        .Include(author => author.AuthorGenreJoinEntities)
        .ThenInclude(join => join.Genre)
        .Include(author => author.AuthorSubgenreJoinEntities)
        .ThenInclude(join => join.Subgenre)
        .FirstOrDefault(author => author.AuthorId == id);
      return View(thisauthor);
    }

    public ActionResult Edit(int id)
    {
      var thisauthor = _db.Authors.FirstOrDefault(author => author.AuthorId == id);
      return View(thisauthor);
    }

    [HttpPost]
    public ActionResult Edit(Author author)
    {
      _db.Entry(author).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = author.AuthorId});
    }

    public ActionResult Delete(int id)
    {
      var thisauthor = _db.Authors.FirstOrDefault(author => author.AuthorId == id);
      return View(thisauthor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisauthor = _db.Authors.FirstOrDefault(author => author.AuthorId == id);
      _db.Authors.Remove(thisauthor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    
  }
}