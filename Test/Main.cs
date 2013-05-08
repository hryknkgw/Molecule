using System;
using System.IO;
using Molecule;

namespace Test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var p = new PDBParser ();
			Console.WriteLine(Directory.GetCurrentDirectory());
			foreach (string pdbfile in Directory.GetFiles(".", "*.pdb")) {
				Console.WriteLine(pdbfile);
				var s = p.Parse (pdbfile);
				Console.WriteLine (s);
			}
		}
	}
}
