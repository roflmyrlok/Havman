using System;
using System.Collections.Generic;

namespace Havman
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> lines = new FileReader().ReadLines("lines.txt");
			SplitLines charsDict = new SplitLines();
			charsDict.splitNFill(lines);
		}
	}
}