using System;
using System.Linq;
using System.Collections.Generic;

namespace Molecule
{
	public class Chain : IComparable<Chain>
	{
		public char ChainID { get; set;}
		public List<Residue> Residues { get; set;}
		public List<Atom> Atoms { get; set;}
		
		public Chain (char chainID, List<Residue> residues = null, List<Atom> atoms = null)
		{
			ChainID = chainID;
			Residues = residues ?? new List<Residue>();
			Atoms = atoms ?? new List<Atom>();
		}
		
		public int CompareTo(Chain chain) {
			return ChainID.CompareTo(chain.ChainID);
		}
	}
}

