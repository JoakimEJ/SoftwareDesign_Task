using Oppgave3.Vendors.JuiceVendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Oppgave3
{
	class JuiceVendor : Vendor
	{
		// Fields
		private ListOfJuiceVendorProducts _allProducts;

		// Constructor
		public JuiceVendor(string name) : base(name)
		{
			_allProducts = new ListOfJuiceVendorProducts();
		}

		public override void CreateProduct(int amountOfItems)
		{
			AmountOfItems = amountOfItems;

			for (int i = 0; i < amountOfItems; i++)
			{
				Product tempProduct = _allProducts.RandomProduct(i);

				Console.WriteLine(this.Name + " made: " + tempProduct.ToString());

				ProductPool.Enqueue(tempProduct);
				Thread.Sleep(500);
			}
			HasEnded = true;
		}
	}
}
