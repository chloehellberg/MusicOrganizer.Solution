using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class RecordsController : Controller
  {
    [HttpGet("/records")]
    public ActionResult Index()
    {
      List<Record> allRecords = Record.GetAllRecords();
      return View(allRecords);
    }

    [HttpGet("/records/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpPost("/records")]
    public ActionResult Create(string inputTitle)
    {
      Record userRecord = new Record(inputTitle);
      return RedirectToAction("Index");
    }
  }
}