using System.Collections.Generic; 
using Microsoft.EntityFrameworkCore; 
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HairSalon.Controllers
{
  public class StylistController : Controller 
  { 

    private readonly HairSalonContext _db;

    public StylistController(HairSalonContext db) 
    {
      _db = db; 
    }

    public ActionResult Index()
    {
      List<Client> model = _db.HairSalon.Include(stylist => stylist.Name).ToList(); 
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.StylistId = new SelectList(_db.Types, "StylistId", "Name");
      return View(); 
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(clients); 
      _db.SaveChanges(); 
      return RedirectToAction("Index"); 
    }

    public ActionResult Show(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(cliend => client.ClientId == id); 
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylists, "StylistId", "StylistName");
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges(); 
      return RedirectToAction("Index"); 
    }

    public ActionResult Delete(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient); 
      _db.SaveChanges(); 
      return RedirectToAction("Index"); 
    }
  }
}