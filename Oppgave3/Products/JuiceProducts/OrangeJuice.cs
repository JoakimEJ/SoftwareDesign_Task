using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	class OrangeJuice : Product
	{
		private readonly string _name = "Weird and sour applejuice";

		public OrangeJuice(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
