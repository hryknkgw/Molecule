using System;
using System.Linq;
using System.Collections.Generic;

namespace Molecule
{
	public class Atom : IComparable<Atom>
	{
		public int Serial { get; set;}
		public string Name { get; set;}
		public char AltLoc { get; set;}
		public string ResName { get; set;}
		public char ChainID { get; set;}
		public int ResSeq { get; set;}
		public char ICode { get; set;}
		public double X { get; set;}
		public double Y { get; set;}
		public double Z { get; set;}
		public double Occupancy { get; set;}
		public double TempFactor { get; set;}
		public string Element { get; set;}
		public string Charge { get; set;}
		public Residue Residue { get; set; }
		public Chain Chain { get; set; }
		
		public Atom (int serial, string name, char altLoc, string resName, char chainID, int resSeq, char iCode, double x, double y, double z, double occupancy, double tempFactor, string element, string charge, Residue residue = null, Chain chain = null)
		{
			Serial = serial;
			Name = name;
			AltLoc = altLoc;
			ResName = resName;
			ChainID = chainID;
			ResSeq = resSeq;
			ICode = iCode;
			X = x;
			Y = y;
			Z = z;
			Occupancy = occupancy;
			TempFactor = tempFactor;
			Element = element;
			Charge = charge;
			Residue = residue;
			Chain = chain;
		}
		
		public int CompareTo(Atom atom)
		{
			return Serial.CompareTo(atom.Serial);
		}

		public bool IsHeteroAtom ()
		{
			return this is HeteroAtom;
		}
	}

	public class HeteroAtom : Atom {
		public HeteroAtom (int serial, string name, char altLoc, string resName, char chainID, int resSeq, char iCode, double x, double y, double z, double occupancy, double tempFactor, string element, string charge, Residue residue = null, Chain chain = null) : base(serial, name, altLoc, resName, chainID, resSeq, iCode, x, y, z, occupancy, tempFactor, element, charge, residue, chain)
		{
		}
	}
}

