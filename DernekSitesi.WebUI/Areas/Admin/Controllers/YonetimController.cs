using DernekSitesi.Entities;
using DernekSitesi.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DernekSitesi.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class YonetimController : Controller
	{
		private readonly IService<Yonetim> _service;

		public YonetimController(IService<Yonetim> service)
		{
			_service = service;
		}

		// GET: YonetimController
		public async Task<ActionResult> IndexAsync()
		{
			var model = await _service.GetAllAsync();
			return View(model);
		}

		// GET: YonetimController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: YonetimController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: YonetimController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Yonetim yonetim)
		{
			try
			{
				_service.Add(yonetim);
				_service.Save();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: YonetimController/Edit/5
		public async Task<ActionResult> EditAsync(int id)
		{
			var model = await _service.FindAsync(id);
			return View(model);
		}

		// POST: YonetimController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, Yonetim yonetim)
		{
			try
			{
				_service.Update(yonetim);
				_service.Save();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: YonetimController/Delete/5
		public async Task<ActionResult> DeleteAsync(int id)
		{
            var model = await _service.FindAsync(id);
            return View(model);
        }

		// POST: YonetimController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, Yonetim yonetim)
		{
			try
			{
				_service.Delete(yonetim);
				_service.Save();
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
