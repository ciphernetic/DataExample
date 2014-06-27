using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using DataExample.Db.Entities;

namespace DataExample
{
	public static class Read
	{
		public static List<Whiskey> FromCSV(string filePath)
		{
			return File.ReadAllLines(filePath).Select(d => {
				string[] x = d.Split(',');
				int[] y = x.Skip(1).Select(z => Convert.ToInt32(z)).ToArray();

				return new Whiskey(x[0], y[0], y[1], y[2], y[3], y[4], y[5],
					y[6], y[7], y[8], y[9], y[10], y[11]);})
				.ToList();
		}
	}
}
