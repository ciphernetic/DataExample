using System;

namespace DataExample.Db.Entities
{
	public class Whiskey
	{
		public string Name { get; set; }
		public int Body { get; set; }
		public int Sweet { get; set; }
		public int Smoke { get; set; }
		public int Medicinal { get; set; }
		public int Tobacco { get; set; }
		public int Honey { get; set; }
		public int Spicy { get; set; }
		public int Winney { get; set; }
		public int Nutty { get; set; }
		public int Malty { get; set; }
		public int Fruity { get; set; }
		public int Floral { get; set; }

		/// <summary>
		/// Base constructor.
		/// </summary>
		/// <param name="name"></param>
		public Whiskey(string name, int body, int sweet, int smoke,
			int medicinal, int tobacco, int honey, int spicy, int winney,
			int nutty, int malty, int fruity, int floral)
		{
			Name = name;
			Body = body;
			Sweet = sweet;
			Smoke = smoke;
			Medicinal = medicinal;
			Tobacco = tobacco;
			Honey = honey;
			Spicy = spicy;
			Winney = winney;
			Nutty = nutty;
			Malty = malty;
			Fruity = fruity;
			Floral = floral;
		}

		/// <summary>
		/// Constructor takes an ordered comma delimited string that represents
		/// all values in the whiskey class.
		/// </summary>
		/// <param name="delimitedRow">Ordered comma delimited string.</param>
		public Whiskey(string delimitedRow)
		{
			string[] cols = delimitedRow.Split(',');

		}
	}
}
