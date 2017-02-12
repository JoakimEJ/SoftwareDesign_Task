using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3.Vendors.Bakery
{
	class ListOfBakeryProducts
	{
		private enum ListOfProducts
		{
			CaramelCookie,
			ChocolateCookie,
			CodCookie,
			HashishBrownie,
			PeanutCookie,
			TurkeyCookie,
			UnicornCookie,
			VanillaCookie
		}

		public Product RandomProduct(int id)
		{
			Random random = new Random();

			List<ListOfProducts> list = Enum.GetValues(typeof(ListOfProducts))
				.Cast<ListOfProducts>()
				.ToList();

			switch (list[random.Next(list.Count)])
			{
				case ListOfProducts.CaramelCookie:
					return new CaramelCookie(id);

				case ListOfProducts.ChocolateCookie:
					return new ChocolateCookie(id);

				case ListOfProducts.CodCookie:
					return new CodCookie(id);

				case ListOfProducts.HashishBrownie:
					return new HashishBrownie(id);

				case ListOfProducts.PeanutCookie:
					return new PeanutCookie(id);

				case ListOfProducts.TurkeyCookie:
					return new TurkeyCookie(id);

				case ListOfProducts.UnicornCookie:
					return new UnicornCookie(id);

				case ListOfProducts.VanillaCookie:
					return new VanillaCookie(id);

				default:
					return new VanillaCookie(id);

			}
		}		
	}
}
