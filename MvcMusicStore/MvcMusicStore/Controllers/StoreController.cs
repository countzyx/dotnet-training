using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcMusicStore.Models;
using MvcMusicStore.ViewModels;

namespace MvcMusicStore.Controllers
{
	public class StoreController : Controller
	{
		// GET: /Store/
		public ActionResult Index()
		{
			var sGenres = new List<string> { "Country", "Disco", "Jazz", "Pop", "Rock" };
			var oViewModel = new StoreIndexViewModel
			{
				NumberOfGenres = sGenres.Count(),
				Genres = sGenres
			};

			ViewBag.Starred = new List<string>() { "Jazz", "Rock" };

			return this.View(oViewModel);
		}

		// GET: /Store/Browse?genre=Disco
		public ActionResult Browse(string genre)
		{
			var oGenreModel = new Genre()
			{
				Name = genre
			};

			var oAlbums = new List<Album>()
			{
				new Album() {Title = genre + " Album 1"},
				new Album() {Title = genre + " Album 2"}
			};

			var oViewModel = new StoreBrowseViewModel()
			{
				Genre = oGenreModel,
				Albums = oAlbums
			};

			return this.View(oViewModel);
		}

		// GET: /Store/Details/5
		public ActionResult Details(int id)
		{
			var oAlbum = new Album() 
			{
				Title = "Sample Album"
			};

			return this.View(oAlbum);
		}
	}
}
