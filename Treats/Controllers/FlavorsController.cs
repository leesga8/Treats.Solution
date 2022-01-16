using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Treats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Treats
{
  public class FlavorsController : Controller
  {
    private readonly TreatsContext _db;

    public FlavorsController (TreatsContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
    public ActionResult Details(int id)
    {
      var thisFlavor = _db.Flavors
          .Include(flavor => flavor.JoinEntities)
          .ThenInclude(join => join.Treat)
          .FirstOrDefault(flavor => flavor.FlavorId == id);
      return View(thisFlavor);
    }
  }
}