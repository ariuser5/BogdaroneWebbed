using BogdaroneWebbed.Models;

namespace BogdaroneWebbed.ViewModels
{
	class HomePageViewModel : PageBaseViewModel
	{

		public HomePageViewModel(CompanyInfo companyInfo) :
			base(companyInfo)
		{ }

		protected override string GetTtile()
			=> "Home Page";


	}
}
