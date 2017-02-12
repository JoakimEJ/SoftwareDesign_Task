using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class ChocolateCookie : Product
	{
		private readonly string _name = "Chocolate cookie";

		public ChocolateCookie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
