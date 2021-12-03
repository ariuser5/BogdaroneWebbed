using BogdaroneWebbed.Models;

namespace BogdaroneWebbed.ViewModels
{
	class ContactPageViewModel : PageBaseViewModel
	{

		public ContactPageViewModel(CompanyInfo companyInfo) :
			base(companyInfo)
		{ }

		protected override string GetTtile()
			=> "Page";


	}
}
