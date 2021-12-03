using BogdaroneWebbed.Models;

namespace BogdaroneWebbed.ViewModels
{
	public class ErrorViewModel : PageBaseViewModel
	{

		public ErrorViewModel(
			CompanyInfo companyInfo,
			RequestError error) :
			base(companyInfo)
		{
			this.Error = error;
		}


		public RequestError Error { get; }


		protected override string GetTtile()
			=> "Error";


	}
}
