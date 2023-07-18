using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
	public class MembersOnly : Controller
	{
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
	}
}
