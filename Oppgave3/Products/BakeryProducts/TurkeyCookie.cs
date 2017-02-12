using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class TurkeyCookie : Product
	{
		private readonly string _name = "Turkey cookie";

		public TurkeyCookie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
