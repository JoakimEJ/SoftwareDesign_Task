using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	class AppleJuice : Product
	{
		private readonly string _name = "Supermega fresh applejuice";

		public AppleJuice(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
