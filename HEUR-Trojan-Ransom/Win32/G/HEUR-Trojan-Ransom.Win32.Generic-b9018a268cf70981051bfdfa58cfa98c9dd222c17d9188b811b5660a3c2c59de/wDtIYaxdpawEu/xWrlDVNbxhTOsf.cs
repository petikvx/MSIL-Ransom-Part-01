using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

internal sealed class xWrlDVNbxhTOsf
{
	public sealed class LabYGxEYpW
	{
		public bool VhGsBzoCylh;

		public bool KDTAovMeoBPNJTK;

		public bool vioBJgdxdnjNleu;

		public int xJMOEPLhBWLg = 25;

		public List<string> ZuMQbmDroMa = new List<string>
		{
			getString_0(107376512),
			getString_0(107376471),
			getString_0(107400932),
			getString_0(107376458)
		};

		public string etYBcVzdLCWh;

		public string bPhZsXpMLOjrl;

		public string gSnonYlkbOhXScFG;

		public string NrJwSfNFERn;

		public string JWbcmVvIVOxvlS;

		public string aAfbYEFSVANrEpG;

		[NonSerialized]
		internal static GetString getString_0;

		static LabYGxEYpW()
		{
			Strings.CreateGetStringDelegate(typeof(LabYGxEYpW));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> ApARTPDOaTQ(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107377214).ToCharArray(), 2);
			list.Add(array[0]);
			if (array.Length == 1)
			{
				dictionary[array[0]] = new string[1] { getString_0(107397188) };
			}
			if (array.Length == 2)
			{
				dictionary[array[0]] = new string[1] { array[1] };
			}
		}
		return dictionary;
	}

	public static LabYGxEYpW qPAyYVIQjSFnl(Dictionary<string, string[]> dictionary_0)
	{
		LabYGxEYpW labYGxEYpW = new LabYGxEYpW();
		if (dictionary_0.ContainsKey(getString_0(107377241)))
		{
			labYGxEYpW.etYBcVzdLCWh = dictionary_0[getString_0(107377241)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377236)))
		{
			labYGxEYpW.bPhZsXpMLOjrl = dictionary_0[getString_0(107377236)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377191)))
		{
			labYGxEYpW.ZuMQbmDroMa = dictionary_0[getString_0(107377191)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107377210)))
		{
			labYGxEYpW.gSnonYlkbOhXScFG = dictionary_0[getString_0(107377210)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377201)))
		{
			labYGxEYpW.NrJwSfNFERn = dictionary_0[getString_0(107377201)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107376652)))
		{
			labYGxEYpW.JWbcmVvIVOxvlS = dictionary_0[getString_0(107376652)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107376639)))
		{
			labYGxEYpW.VhGsBzoCylh = Convert.ToBoolean(dictionary_0[getString_0(107376639)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107376658)))
		{
			labYGxEYpW.aAfbYEFSVANrEpG = dictionary_0[getString_0(107376658)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107376613)))
		{
			labYGxEYpW.xJMOEPLhBWLg = Convert.ToInt32(dictionary_0[getString_0(107376613)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107376632)))
		{
			labYGxEYpW.KDTAovMeoBPNJTK = Convert.ToBoolean(dictionary_0[getString_0(107376632)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107376587)))
		{
			labYGxEYpW.vioBJgdxdnjNleu = Convert.ToBoolean(dictionary_0[getString_0(107376587)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107376574)))
		{
			EJxuSRomeEwS();
			labYGxEYpW = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107377210)) && !dictionary_0.ContainsKey(getString_0(107377201)))
		{
			Console.WriteLine(getString_0(107376597));
			EJxuSRomeEwS();
			labYGxEYpW = null;
		}
		return labYGxEYpW;
	}

	public static bool mYhSiZJAnJuq(LabYGxEYpW labYGxEYpW_0)
	{
		return true;
	}

	public static void EJxuSRomeEwS()
	{
	}

	static xWrlDVNbxhTOsf()
	{
		Strings.CreateGetStringDelegate(typeof(xWrlDVNbxhTOsf));
	}
}
