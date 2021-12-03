using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogdaroneWebbed
{
	public static class Utils
	{
	
		public static string NameOfController(Type controllerType)
		{
			return controllerType.Name.Replace("Controller", string.Empty);
		}


	}
}
