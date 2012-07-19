using System;

namespace Test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var p = new Molecule.PDBParser();
			p.Parse("2BBM.pdb");
		}
	}
}
