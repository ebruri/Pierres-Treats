using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Pierres.Models;
using System.Collections.Generic;
using System.Linq;


namespace Pierres.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresContext _db;

    public HomeController(PierresContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}