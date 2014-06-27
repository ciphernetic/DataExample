using System;
using System.Collections.Generic;
using System.Linq;

using DataExample.Db.Entities;

namespace DataExample.Cli
{
	static class Program
	{
		private static int Main(string[] args)
		{
			if(1 == args.Length)
			{
				List<Whiskey> whiskies = Read.FromCSV(args[0]);

				Console.WriteLine("Mean Honey = {0}", whiskies.Average(w => w.Honey));
			}
			else
			{
				throw new ArgumentException("File not supplied.");
			}

			return 0;
		}
	}
}
