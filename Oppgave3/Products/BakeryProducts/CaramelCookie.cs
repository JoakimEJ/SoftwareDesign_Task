using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class CaramelCookie : Product
	{
		private readonly string _name = "Caramel cookie";

		public CaramelCookie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
