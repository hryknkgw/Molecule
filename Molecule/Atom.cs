using System;
using System.Linq;

namespace Molecule
{
	public class Atom
	{
		public string[] S {get; set;}
		public Atom (System.Collections.Generic.IEnumerable<string> s)
		{
			S = s.ToArray();
		}
	}
}

