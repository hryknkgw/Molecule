using System;

namespace Test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var p = new Molecule.PDBParser ();
			var s = p.Parse ("2GK0.pdb");
			System.Console.WriteLine (s);
		}
	}
}
