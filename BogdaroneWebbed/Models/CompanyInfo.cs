using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BogdaroneWebbed.Models;

namespace BogdaroneWebbed.Models
{
	public class CompanyInfo
	{
		
		public CompanyName Name { get; set; }
		public object Logo { get; set; }



		public override string ToString()
		{
			return this.Name.FullName;
		}


	}
}
