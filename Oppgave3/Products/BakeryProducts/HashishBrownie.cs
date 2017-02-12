using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3
{
	
	class HashishBrownie : Product
	{
		private readonly string _name = "Hashish Brownie";

		public HashishBrownie(int id) : base(id)
		{
			base.Name = this._name;
		}
	}
}
