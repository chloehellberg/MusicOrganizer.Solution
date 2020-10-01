using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
  public class Search_By_ArtistController : Controller
  {

    [HttpGet("/search_by_artist")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/search_by_artist/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/search_by_artist")]
    public ActionResult Create(string inputArtistName)
    {
      List<Artist> matchingArtists = new List<Artist>{};
      List<Artist> allArtists = Artist.GetAllArtists();
      foreach (Artist artist in allArtists)
      {
        if (artist.Name.ToUpper() == inputArtistName.ToUpper() || artist.Name.Contains(inputArtistName))
        {
          matchingArtists.Add(artist);
        }
      }
      return View("Index", matchingArtists);
    }
  }
}