using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieShop.Core.Models.Request;

namespace MovieShop.MVC.Controllers
{
	public class AccountController : Controller
	{

		[HttpGet]
		public async Task<IActionResult> Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(UserRegisterRequestModel requestModel)
		{
			// Model Binding
			// Form, it will look for input elements names and if those names match with our Action menthod model
			// properties
			// then it will automatically map that data            
			// a control with name=EMAIL "abc@abc.com"
			// UserRegisterRequestModel => Email

			return View();
		}


	}
}