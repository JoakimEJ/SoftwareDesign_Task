using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class UnicornCookie : Product
	{
		private readonly string _name = "Unicorn cookie";

		public UnicornCookie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
