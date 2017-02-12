using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Oppgave3
{
	abstract class Vendor
	{
		// Fields
		private string _name;
		private Queue<Product> _productPool;
		private int _amountOfItems;
		// MY LOCK!
		private object _lockThis = new object();
		// IMPORTANT BOOLEAN
		private bool _hasEnded;

		// Properties
		public string Name { get { return _name; } }
		protected Queue<Product> ProductPool { get { return _productPool; } }
		public int AmountOfItems { get { return _amountOfItems; } set { _amountOfItems = value; } }
		public bool HasEnded { get { return _hasEnded; } set { _hasEnded = value; } }

		// Constructor
		public Vendor(string name)
		{
			this._name = name;
			_productPool = new Queue<Product>();
			_hasEnded = false;
		}

		// PUT A LOCK ON IT!
		public virtual void sellTo(Customer customer)
		{
			var timeout = TimeSpan.FromMilliseconds(5);

			if(Monitor.TryEnter(_lockThis, timeout))
			{ 
				try
				{
					if (_productPool.Count() != 0)
					{
						Product temp = _productPool.Peek();
						Console.WriteLine("                                                                    "
							+ customer.Name + " grabbed the " + this._name + "'s " + temp.ToString());
						_productPool.Dequeue();
						_amountOfItems--;
					}
				}
				finally
				{
					Monitor.Exit(_lockThis);
				}
				
			}
				
		}

		public abstract void CreateProduct(int amountOfItems);
		//public abstract void createProduct2(int amountOfItems);
		// Keep for showing how Vendor can be expanded to create different products

		// Utilities for this class

		public bool isClosed()
		{
			if(_amountOfItems <= 0 && _hasEnded == true)
			{
				return true;
			}
			return false;
		}
	}
}
