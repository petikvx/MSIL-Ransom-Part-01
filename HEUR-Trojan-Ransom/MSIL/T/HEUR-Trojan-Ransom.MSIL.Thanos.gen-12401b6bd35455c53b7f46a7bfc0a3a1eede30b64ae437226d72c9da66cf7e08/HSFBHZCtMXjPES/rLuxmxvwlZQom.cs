using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

internal sealed class rLuxmxvwlZQom
{
	public sealed class rdUxlcrLRAL
	{
		public bool vkYXdaaSmGnyA = false;

		public bool AurhoQDaxEntQW = false;

		public bool InjrfdiqCoCt = false;

		public bool xtgEnLddjyIS = false;

		public int TzpVQGJqGeVIiRK = 25;

		public List<string> AnsdRDnoiUICV = new List<string>
		{
			getString_0(107362712),
			getString_0(107362703),
			getString_0(107384790),
			getString_0(107362658)
		};

		public string FxnLNjQzsBbyZ = null;

		public string ctFDSNjxohlpStG = null;

		public string tpeHJejVEHTtixGDd = null;

		public string qphflUvlCEQ = null;

		public string hmHwvlmDTtRNekSJ = null;

		public string JuxWBFLpnrvG = null;

		[NonSerialized]
		internal static GetString getString_0;

		static rdUxlcrLRAL()
		{
			Strings.CreateGetStringDelegate(typeof(rdUxlcrLRAL));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> DitYsaYulJ(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		string[] array = new string[3]
		{
			getString_0(107363413),
			getString_0(107363432),
			getString_0(107363387)
		};
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array2 = text.Split(getString_0(107363374).ToCharArray(), 2);
			list.Add(array2[0]);
			if (array2.Length == 1)
			{
				dictionary[array2[0]] = new string[1] { getString_0(107396827) };
			}
			if (array2.Length == 2)
			{
				dictionary[array2[0]] = new string[1] { array2[1] };
			}
		}
		return dictionary;
	}

	public static rdUxlcrLRAL fzJOeyiDdbuH(Dictionary<string, string[]> dictionary_0)
	{
		rdUxlcrLRAL rdUxlcrLRAL = new rdUxlcrLRAL();
		if (dictionary_0.ContainsKey(getString_0(107363401)))
		{
			rdUxlcrLRAL.FxnLNjQzsBbyZ = dictionary_0[getString_0(107363401)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107363396)))
		{
			rdUxlcrLRAL.ctFDSNjxohlpStG = dictionary_0[getString_0(107363396)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107363351)))
		{
			rdUxlcrLRAL.AnsdRDnoiUICV = dictionary_0[getString_0(107363351)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107363370)))
		{
			rdUxlcrLRAL.tpeHJejVEHTtixGDd = dictionary_0[getString_0(107363370)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107363361)))
		{
			rdUxlcrLRAL.qphflUvlCEQ = dictionary_0[getString_0(107363361)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107363356)))
		{
			rdUxlcrLRAL.hmHwvlmDTtRNekSJ = dictionary_0[getString_0(107363356)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107363413)))
		{
			rdUxlcrLRAL.AurhoQDaxEntQW = Convert.ToBoolean(dictionary_0[getString_0(107363413)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107363311)))
		{
			rdUxlcrLRAL.JuxWBFLpnrvG = dictionary_0[getString_0(107363311)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107363330)))
		{
			rdUxlcrLRAL.TzpVQGJqGeVIiRK = Convert.ToInt32(dictionary_0[getString_0(107363330)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107363432)))
		{
			rdUxlcrLRAL.InjrfdiqCoCt = Convert.ToBoolean(dictionary_0[getString_0(107363432)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107363387)))
		{
			rdUxlcrLRAL.xtgEnLddjyIS = Convert.ToBoolean(dictionary_0[getString_0(107363387)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107362773)))
		{
			OyZTtQodBDKeO();
			rdUxlcrLRAL = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107363370)) && !dictionary_0.ContainsKey(getString_0(107363361)))
		{
			Console.WriteLine(getString_0(107362764));
			OyZTtQodBDKeO();
			rdUxlcrLRAL = null;
		}
		return rdUxlcrLRAL;
	}

	public static bool mMfYiXjKmcJZ(rdUxlcrLRAL rdUxlcrLRAL_0)
	{
		return true;
	}

	public static void OyZTtQodBDKeO()
	{
	}

	static rLuxmxvwlZQom()
	{
		Strings.CreateGetStringDelegate(typeof(rLuxmxvwlZQom));
	}
}
