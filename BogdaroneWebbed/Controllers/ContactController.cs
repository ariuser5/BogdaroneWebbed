using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BogdaroneWebbed.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BogdaroneWebbed.Controllers
{
	public class ContactController: Controller
	{

		private readonly ILogger<ContactController> _logger;

		public ContactController(ILogger<ContactController> logger)
		{
			this._logger = logger;
		}


		public IActionResult Contact()
		{
			var company = DataBase.GetCompanyInfo();
			var viewModel = new ContactPageViewModel(company);

			return this.View("Views/Contact.cshtml", viewModel);
		}


	}
}
