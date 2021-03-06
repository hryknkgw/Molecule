using System;
using System.Linq;
using System.Collections.Generic;

namespace Molecule
{
	public class Residue : IComparable<Residue>
	{
		public string ResName { get; set;}
		public char ChainID { get; set;}
		public int ResSeq { get; set;}
		public char ICode { get; set;}
		public List<Atom> Atoms { get; set;}
		
		public Residue (string resName, char chainID, int resSeq, char iCode, List<Atom> atoms = null)
		{
			ResName = resName;
			ChainID = chainID;
			ResSeq = resSeq;
			ICode = iCode;
			Atoms = atoms ?? new List<Atom>();
		}
		
		public int CompareTo(Residue residue) {
			return (ResSeq.Equals(residue.ResSeq))?ICode.CompareTo(residue.ICode):ResSeq.CompareTo(residue.ResSeq);
		}
	}
}

