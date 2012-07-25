using System;
using System.Linq;
using System.Collections.Generic;

namespace Molecule
{
	public class Structure
	{
		public List<Chain> Chains { get; set; }
		public List<Residue> Residues { get; set; }
		public List<Atom> Atoms {get; set;}
		public double Resolution {get; set;}
		public double RFree {get; set;}
		
		public Structure ()
		{
			Chains = new List<Chain>();
			Residues = new List<Residue>();
			Atoms = new List<Atom>();
		}
	}
}

