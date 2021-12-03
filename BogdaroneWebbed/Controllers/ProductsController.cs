using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BogdaroneWebbed.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BogdaroneWebbed.Controllers
{
	public class ProductsController: Controller
	{

		private readonly ILogger<ProductsController> _logger;

		public ProductsController(ILogger<ProductsController> logger)
		{
			this._logger = logger;
		}


		public IActionResult Products()
		{
			var company = DataBase.GetCompanyInfo();
			var viewModel = new ProductsViewModel(company);

			return this.View("Views/Products.cshtml", viewModel);
		}
	}
}
