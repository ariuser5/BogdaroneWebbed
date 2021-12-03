using BogdaroneWebbed.Models;

namespace BogdaroneWebbed
{
	public class DataBase
	{

		public static CompanyInfo GetCompanyInfo()
		{
			return new CompanyInfo()
			{
				Name = new CompanyName("Bogdarone", "S.R.L.")
			};
		}


	}
}
