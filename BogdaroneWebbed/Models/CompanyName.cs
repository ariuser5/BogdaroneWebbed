using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogdaroneWebbed.Models
{
	public class CompanyName
	{

		public const string PREFIX = "S.C.";


		public CompanyName()
		{ }

		public CompanyName(string name) : this()
		{
			this.Name = name;
		}

		public CompanyName(string name, string suffix) : this(name)
		{
			this.Suffix = suffix;
		}


		public string Name { get; set; }
		public string Suffix { get; set; }

		public string ShortSpell => $"{this.Name} {this.Suffix}";

		public string FullName => $"{PREFIX} {this.ShortSpell}";


		public override string ToString()
		{
			return $"CompanyName: '{this.FullName}'";
		}

	}
}
