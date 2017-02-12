using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class VanillaCookie : Product
	{
		private readonly string _name = "Vanilla cookie";

		public VanillaCookie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
