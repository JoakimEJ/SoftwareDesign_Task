using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class PeanutCookie : Product
	{
		private readonly string _name = "Peanut cookie";

		public PeanutCookie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
