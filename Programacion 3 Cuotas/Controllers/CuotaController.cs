using Microsoft.AspNetCore.Mvc;
using Programacion_3_Cuotas.Models;

namespace Programacion_3_Cuotas.Controllers
{
	public class CuotaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]

		public IActionResult Index(PrestamoViewModel value)
		{
			ViewData["message"] = CuotaViewModel.Cuota(value).ToString();
			return View(value);
		}
	}
}
