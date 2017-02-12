using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Oppgave3.Vendors.Bakery;

namespace Oppgave3
{
	class Bakery : Vendor
	{
		// Fields
		private ListOfBakeryProducts _allProducts;
		
		// Constructor
		public Bakery(string name) : base(name)
		{
			_allProducts = new ListOfBakeryProducts();
		}

		public override void CreateProduct(int amountOfItems)
		{
			
			AmountOfItems = amountOfItems;

			for(int i = 0; i < amountOfItems; i++)
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
