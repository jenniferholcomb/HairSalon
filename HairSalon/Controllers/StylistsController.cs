using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;

    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Stylist> model = _db.Stylists.OrderBy(stylist => stylist.Name).ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Dictionary<List<client>, object> dictStylist = new Dictionary<List<client>, object>();
      List<Client> model = _db.Clients
                              .Include(client => client.Stylist)
                              .OrderBy(client => client.Name)
                              .ToList();

      Stylist thisStylist = _db.Stylists
                               .Include(model)
                               .FirstOrDefault(stylist => stylist.StylistId == id);
      return View(thisStylist);
    }
  }
}
      // Dictionary<string, object> model = new Dictionary<string, object>();
      // Vendor foundVendor = Vendor.Find(vendor.Id);
      // List<Order> vendorOrders = foundVendor.OrderItems;
      // model.Add("orders", vendorOrders);
      // model.Add("vendor", foundVendor);