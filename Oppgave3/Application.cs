using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Oppgave3
{
	class Application
	{

		public static void Main(string[] args)
		{
			// Set up vendor list for costumer parameters
			List<Vendor> myVendorList = new List<Vendor>();
			Vendor bakery1 = new Bakery("Baked hipsters");
			Vendor bakery2 = new Bakery("Grannys");
			Vendor juiceVendor1 = new JuiceVendor("Lord of the juices");
			myVendorList.Add(bakery1);
			myVendorList.Add(bakery2);
			myVendorList.Add(juiceVendor1);

			// Set up customers
			Customer c1 = new Customer("Nikita", myVendorList);
			Customer c2 = new Customer("Joakim", myVendorList);
			Customer c3 = new Customer("Robert", myVendorList);

			// prepare threads
			Thread vendorThread1 = new Thread(() => bakery1.CreateProduct(9));
			Thread vendorThread2 = new Thread(() => bakery2.CreateProduct(5));
			Thread vendorThread3 = new Thread(() => juiceVendor1.CreateProduct(8));
			Thread customerThread1 = new Thread(() => c1.StartGrabbingProduct(myVendorList));
			Thread customerThread2 = new Thread(() => c2.StartGrabbingProduct(myVendorList));
			Thread customerThread3 = new Thread(() => c3.StartGrabbingProduct(myVendorList));

			// Start Threads
			customerThread1.Start();
			customerThread2.Start();
			customerThread3.Start();
			vendorThread1.Start();
			vendorThread2.Start();
			vendorThread3.Start();

			// Keep window from closing
			Console.ReadKey(true);

		}
	}
}
