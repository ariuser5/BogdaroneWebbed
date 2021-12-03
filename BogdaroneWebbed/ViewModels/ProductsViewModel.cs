using BogdaroneWebbed.Models;

namespace BogdaroneWebbed.ViewModels
{
	public class ProductsViewModel: PageBaseViewModel
	{

		public ProductsViewModel(CompanyInfo companyInfo) : 
			base(companyInfo)
		{ }

		protected override string GetTtile()
			=> "Products";


	}
}
