using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	class KiwiJuice : Product
	{
		private readonly string _name = "Kiwijuice, the bird - not the fruit";

		public KiwiJuice(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
