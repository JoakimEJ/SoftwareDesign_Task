using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class CodCookie : Product
	{
		private readonly string _name = "Cod flavoured cookie";

		public CodCookie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
