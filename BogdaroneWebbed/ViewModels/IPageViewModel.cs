using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogdaroneWebbed.ViewModels
{
	public interface IPageViewModel
	{
		string Title { get; }
		string TitleSubject { get; }
		string TitleSubjectShort { get; }
	}
}
