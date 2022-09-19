using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

internal sealed class WSBHCLCVUxnNwv
{
	public sealed class inklmAynGkpVL
	{
		public bool LBTMbFaakMCtuQJ;

		public bool LNocBLVhQrx;

		public bool GoqRBBYPEg;

		public int riJMDVFGSiNobcP = 25;

		public List<string> yEHrFOCtrwQ = new List<string>
		{
			getString_0(107350877),
			getString_0(107350868),
			getString_0(107407443),
			getString_0(107350887)
		};

		public string thJOuTJnNdHA;

		public string llINjRZexMaUC;

		public string gZbaddQLFQc;

		public string xAFfqEsPbHG;

		public string mlLcDbMyzRCXr;

		public string rUQDsjrUYNxdJ;

		[NonSerialized]
		internal static GetString getString_0;

		static inklmAynGkpVL()
		{
			Strings.CreateGetStringDelegate(typeof(inklmAynGkpVL));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> wnEFZDAlNWfKO(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107351634).ToCharArray(), 2);
			list.Add(array[0]);
			if (array.Length == 1)
			{
				dictionary[array[0]] = new string[1] { getString_0(107397159) };
			}
			if (array.Length == 2)
			{
				dictionary[array[0]] = new string[1] { array[1] };
			}
		}
		return dictionary;
	}

	public static inklmAynGkpVL CLOoMJuYxMxGb(Dictionary<string, string[]> dictionary_0)
	{
		inklmAynGkpVL inklmAynGkpVL = new inklmAynGkpVL();
		if (dictionary_0.ContainsKey(getString_0(107351597)))
		{
			inklmAynGkpVL.thJOuTJnNdHA = dictionary_0[getString_0(107351597)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107351592)))
		{
			inklmAynGkpVL.llINjRZexMaUC = dictionary_0[getString_0(107351592)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107351611)))
		{
			inklmAynGkpVL.yEHrFOCtrwQ = dictionary_0[getString_0(107351611)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107351054)))
		{
			inklmAynGkpVL.gZbaddQLFQc = dictionary_0[getString_0(107351054)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107351045)))
		{
			inklmAynGkpVL.xAFfqEsPbHG = dictionary_0[getString_0(107351045)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107351072)))
		{
			inklmAynGkpVL.mlLcDbMyzRCXr = dictionary_0[getString_0(107351072)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107351059)))
		{
			inklmAynGkpVL.LBTMbFaakMCtuQJ = Convert.ToBoolean(dictionary_0[getString_0(107351059)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107351014)))
		{
			inklmAynGkpVL.rUQDsjrUYNxdJ = dictionary_0[getString_0(107351014)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107351033)))
		{
			inklmAynGkpVL.riJMDVFGSiNobcP = Convert.ToInt32(dictionary_0[getString_0(107351033)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107350988)))
		{
			inklmAynGkpVL.LNocBLVhQrx = Convert.ToBoolean(dictionary_0[getString_0(107350988)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107351007)))
		{
			inklmAynGkpVL.GoqRBBYPEg = Convert.ToBoolean(dictionary_0[getString_0(107351007)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107388805)))
		{
			XHWlqFiZEO();
			inklmAynGkpVL = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107351054)) && !dictionary_0.ContainsKey(getString_0(107351045)))
		{
			Console.WriteLine(getString_0(107350994));
			XHWlqFiZEO();
			inklmAynGkpVL = null;
		}
		return inklmAynGkpVL;
	}

	public static bool zNDlGYASpdcN(inklmAynGkpVL inklmAynGkpVL_0)
	{
		return true;
	}

	public static void XHWlqFiZEO()
	{
	}

	static WSBHCLCVUxnNwv()
	{
		Strings.CreateGetStringDelegate(typeof(WSBHCLCVUxnNwv));
	}
}
