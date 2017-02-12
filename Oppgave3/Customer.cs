using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Oppgave3
{
	class Customer
	{
		// Fields
		private string _name;
		private List<Vendor> _vendorList;

		// Properties
		public string Name { get { return _name; } }
		public List<Vendor> VendorList { get { return _vendorList; } }

		// Constructor
		public Customer(string name, List<Vendor> vendorList)
		{
			this._name = name;
			this._vendorList = vendorList;
		}

		public void StartGrabbingProduct(List<Vendor> vendorList)
		{
			bool noMoreProducts = false;

			while (!noMoreProducts)
			{
				int openBakeries = vendorList.Count();

				Vendor vendor = RandomVendor(vendorList);
				if (!vendor.isClosed())
				{
					vendor.sellTo(this);
					RandomSleep();
				}

				foreach (Vendor v in vendorList)
				{
					if (v.isClosed()) openBakeries--;
				}
				if (openBakeries <= 0) noMoreProducts = true;
			}
		}

		public Vendor RandomVendor(List<Vendor> vendorList)
		{
			Random random = new Random();
			int r = random.Next(vendorList.Count());

			return vendorList.ElementAt(r);
		}

		public void RandomSleep()
		{
			Random rand = new Random();
			int sleepTime = rand.Next(300, 350);

			Thread.Sleep(sleepTime);
		}
	}
}
