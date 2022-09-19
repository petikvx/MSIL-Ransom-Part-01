using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

internal sealed class huEaYSIwDZHlox
{
	public sealed class LabYGxEYpW
	{
		public bool VhGsBzoCylh;

		public bool KDTAovMeoBPNJTK;

		public bool vioBJgdxdnjNleu;

		public int xJMOEPLhBWLg = 25;

		public List<string> ZuMQbmDroMa = new List<string>
		{
			getString_0(107376588),
			getString_0(107376611),
			getString_0(107400496),
			getString_0(107376566)
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

	public static Dictionary<string, string[]> cApztJadDOu(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107377322).ToCharArray(), 2);
			list.Add(array[0]);
			if (array.Length == 1)
			{
				dictionary[array[0]] = new string[1] { getString_0(107397328) };
			}
			if (array.Length == 2)
			{
				dictionary[array[0]] = new string[1] { array[1] };
			}
		}
		return dictionary;
	}

	public static LabYGxEYpW YycDYcVVnGUhw(Dictionary<string, string[]> dictionary_0)
	{
		LabYGxEYpW labYGxEYpW = new LabYGxEYpW();
		if (dictionary_0.ContainsKey(getString_0(107377317)))
		{
			labYGxEYpW.etYBcVzdLCWh = dictionary_0[getString_0(107377317)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377312)))
		{
			labYGxEYpW.bPhZsXpMLOjrl = dictionary_0[getString_0(107377312)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377331)))
		{
			labYGxEYpW.ZuMQbmDroMa = dictionary_0[getString_0(107377331)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107377286)))
		{
			labYGxEYpW.gSnonYlkbOhXScFG = dictionary_0[getString_0(107377286)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377277)))
		{
			labYGxEYpW.NrJwSfNFERn = dictionary_0[getString_0(107377277)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377304)))
		{
			labYGxEYpW.JWbcmVvIVOxvlS = dictionary_0[getString_0(107377304)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377259)))
		{
			labYGxEYpW.VhGsBzoCylh = Convert.ToBoolean(dictionary_0[getString_0(107377259)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377246)))
		{
			labYGxEYpW.aAfbYEFSVANrEpG = dictionary_0[getString_0(107377246)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377265)))
		{
			labYGxEYpW.xJMOEPLhBWLg = Convert.ToInt32(dictionary_0[getString_0(107377265)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377220)))
		{
			labYGxEYpW.KDTAovMeoBPNJTK = Convert.ToBoolean(dictionary_0[getString_0(107377220)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377239)))
		{
			labYGxEYpW.vioBJgdxdnjNleu = Convert.ToBoolean(dictionary_0[getString_0(107377239)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377194)))
		{
			QSmhLgjatJvSA();
			labYGxEYpW = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107377286)) && !dictionary_0.ContainsKey(getString_0(107377277)))
		{
			Console.WriteLine(getString_0(107377185));
			QSmhLgjatJvSA();
			labYGxEYpW = null;
		}
		return labYGxEYpW;
	}

	public static bool mKTgnHGIlAF(LabYGxEYpW labYGxEYpW_0)
	{
		return true;
	}

	public static void QSmhLgjatJvSA()
	{
	}

	static huEaYSIwDZHlox()
	{
		Strings.CreateGetStringDelegate(typeof(huEaYSIwDZHlox));
	}
}
