using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BogdaroneWebbed.Models;

namespace BogdaroneWebbed.ViewModels
{
	public abstract class PageBaseViewModel : IPageViewModel
	{

		protected PageBaseViewModel(CompanyInfo companyInfo)
		{
			this.CompanyInfo = companyInfo;
		}

		public CompanyInfo CompanyInfo { get; }


		protected abstract string GetTtile();


		string IPageViewModel.Title => this.GetTtile();

		string IPageViewModel.TitleSubject 
			=> this.CompanyInfo.Name.ShortSpell;

		string IPageViewModel.TitleSubjectShort 
			=> this.CompanyInfo.Name.Name;



	}
}
