using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BogdaroneWebbed.Models;
using BogdaroneWebbed.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BogdaroneWebbed.Controllers
{
	public class HomeController: Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			this._logger = logger;
		}

		public IActionResult Index()
		{
			return this.RedirectToAction(nameof(Home));
		}

		public IActionResult Home()
		{
			var company = DataBase.GetCompanyInfo();
			var viewModel = new HomePageViewModel(company);

			return this.View("Views/Home.cshtml", viewModel);
		}

		[ResponseCache(
			Duration = 0, 
			Location = ResponseCacheLocation.None,
			NoStore = true)]
		public IActionResult Error()
		{
			var company = DataBase.GetCompanyInfo();
			var error = new RequestError()
			{
				RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
			};

			var viewModel = new ErrorViewModel(company, error);

			return this.View(viewModel);
		}


	}
}
