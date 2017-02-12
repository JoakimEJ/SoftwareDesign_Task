using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3.Vendors.JuiceVendor
{
	class ListOfJuiceVendorProducts
	{
		private enum ListOfProducts
		{
			AppleJuice,
			OrangeJuice,
			KiwiJuice
		}

		public Product RandomProduct(int id)
		{
			Random random = new Random();

			List<ListOfProducts> list = Enum.GetValues(typeof(ListOfProducts))
				.Cast<ListOfProducts>()
				.ToList();

			switch (list[random.Next(list.Count)])
			{
				case ListOfProducts.AppleJuice:
					return new AppleJuice(id);

				case ListOfProducts.OrangeJuice:
					return new OrangeJuice(id);

				case ListOfProducts.KiwiJuice:
					return new KiwiJuice(id);
			
				default:
					return new KiwiJuice(id);
			}
		}
	}
}
