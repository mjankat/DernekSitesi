using DernekSitesi.Entities;
using DernekSitesi.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DernekSitesi.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]

	public class UsersController : Controller
	{
		private readonly IService<User> _service;
		private readonly IService<Rol> _serviceRol;

        public UsersController(IService<User> service, IService<Rol> serviceRol)
        {
            _service = service;
            _serviceRol = serviceRol;
        }

        // GET: UsersController
        public async Task<ActionResult> IndexAsync()
		{
			var model = await _service.GetAllAsync();
			return View(model);
		}

		// GET: UsersController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: UsersController/Create
		public async Task<ActionResult> CreateAsync()
		{
			ViewBag.RolId = new SelectList(await _serviceRol.GetAllAsync(),"Id","Name");
			return View();
		}

		// POST: UsersController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> CreateAsync(User user)
		{
			if (ModelState.IsValid)
			{
                try
                {
                    await _service.AddAsync(user);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
					ModelState.AddModelError("","Hata Oluştu!");
                }
            }
            ViewBag.RolId = new SelectList(await _serviceRol.GetAllAsync(), "Id", "Name");
            return View(user);
		}

		// GET: UsersController/Edit/5
		public async Task<ActionResult> EditAsync(int id)
		{
			var model = await _service.FindAsync(id);
            ViewBag.RolId = new SelectList(await _serviceRol.GetAllAsync(), "Id", "Name");
            return View(model);
		}

		// POST: UsersController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> EditAsync(int id, User user)
		{
            if (ModelState.IsValid)
            {
                try
                {
                    _service.Update(user);
                    await _service.SaveAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.RolId = new SelectList(await _serviceRol.GetAllAsync(), "Id", "Name");
            return View(user);
        }

		// GET: UsersController/Delete/5
		public async Task<ActionResult> DeleteAsync(int id)
		{
			var model = await _service.FindAsync(id);
			return View(model);
		}

		// POST: UsersController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, User user)
		{
			try
			{
				_service.Delete(user);
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
