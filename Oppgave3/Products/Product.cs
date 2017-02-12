using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	abstract class Product
	{
		// Fields
		private string _name;
		private int _id;
		
		// Properties
		public string Name { set { _name = value; } }
		public int Id { get { return _id; } }

		// Constructor
		public Product(int id)
		{
			this._id = id;
			//this.name = name;
		}

		public override string ToString()
		{
			return _name + " #" + Id;
		}

	}
	
}
