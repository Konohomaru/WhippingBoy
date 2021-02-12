using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CheckController : ControllerBase
	{
		[HttpGet]
		public Check Get()
		{
			return Check.Instance;
		}
	}
}
