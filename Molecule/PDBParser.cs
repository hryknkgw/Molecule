using System;
using System.Linq;

namespace Molecule
{
	public class PDBParser
	{
		public PDBParser ()
		{
		}
		
		public Atom[] Parse(string pdbFile)
		{
			var atoms = new System.Collections.Generic.List<Atom>();
			using(var reader = new System.IO.StreamReader(pdbFile))
			{
				var reAtom = new System.Text.RegularExpressions.Regex("^(.{6})(.{5}).(.{4})(.{1})(.{3}).(.{1})(.{4})(.{1})...(.{8})(.{8})(.{8})(.{6})(.{6})..........(.{2})(.{2})$");
				while(reader.Peek() != -1)
				{
					var line = reader.ReadLine();
					if(line.StartsWith("ATOM"))
					{
						var m = reAtom.Match(line);
						foreach(System.Text.RegularExpressions.Group g in m.Groups)
						{
							System.Console.WriteLine(g.Value);
						}
					}
				}
			}
			return atoms.ToArray();
		}
	}
}

