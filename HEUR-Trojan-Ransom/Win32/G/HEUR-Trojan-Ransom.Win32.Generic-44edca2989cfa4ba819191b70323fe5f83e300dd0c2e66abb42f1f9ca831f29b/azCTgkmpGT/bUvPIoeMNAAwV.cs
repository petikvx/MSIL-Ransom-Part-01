using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class bUvPIoeMNAAwV
{
	public sealed class NEKyzGsocBv
	{
		public bool ksnogyPuQh;

		public bool niYVXBafZsNVAo;

		public bool AEiwHlLfOBSK;

		public int NDzgRiqaaBg = 25;

		public List<string> PestXWGbVnp = new List<string>
		{
			getString_0(107377619),
			getString_0(107377610),
			getString_0(107400766),
			getString_0(107377629)
		};

		public string IFQXsrdSniBZVI;

		public string HKOFImfkdtwJ;

		public string GRSCvqmVTCdpPEKJ;

		public string AsuHoZmUdixtqe;

		public string wYvAGVrLdVxju;

		public string HpZsojMbNHWAb;

		[NonSerialized]
		internal static GetString getString_0;

		static NEKyzGsocBv()
		{
			Strings.CreateGetStringDelegate(typeof(NEKyzGsocBv));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> siqwrNcZAIEX(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107378385).ToCharArray(), 2);
			list.Add(array[0]);
			if (array.Length == 1)
			{
				dictionary[array[0]] = new string[1] { getString_0(107396510) };
			}
			if (array.Length == 2)
			{
				dictionary[array[0]] = new string[1] { array[1] };
			}
		}
		return dictionary;
	}

	public static NEKyzGsocBv gqPyhxTtFnBam(Dictionary<string, string[]> dictionary_0)
	{
		NEKyzGsocBv nEKyzGsocBv = new NEKyzGsocBv();
		if (dictionary_0.ContainsKey(getString_0(107378348)))
		{
			nEKyzGsocBv.IFQXsrdSniBZVI = dictionary_0[getString_0(107378348)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107378343)))
		{
			nEKyzGsocBv.HKOFImfkdtwJ = dictionary_0[getString_0(107378343)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107378362)))
		{
			nEKyzGsocBv.PestXWGbVnp = dictionary_0[getString_0(107378362)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107378317)))
		{
			nEKyzGsocBv.GRSCvqmVTCdpPEKJ = dictionary_0[getString_0(107378317)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107378308)))
		{
			nEKyzGsocBv.AsuHoZmUdixtqe = dictionary_0[getString_0(107378308)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107378303)))
		{
			nEKyzGsocBv.wYvAGVrLdVxju = dictionary_0[getString_0(107378303)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107378322)))
		{
			nEKyzGsocBv.ksnogyPuQh = Convert.ToBoolean(dictionary_0[getString_0(107378322)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107378277)))
		{
			nEKyzGsocBv.HpZsojMbNHWAb = dictionary_0[getString_0(107378277)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107378296)))
		{
			nEKyzGsocBv.NDzgRiqaaBg = Convert.ToInt32(dictionary_0[getString_0(107378296)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107378251)))
		{
			nEKyzGsocBv.niYVXBafZsNVAo = Convert.ToBoolean(dictionary_0[getString_0(107378251)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107378238)))
		{
			nEKyzGsocBv.AEiwHlLfOBSK = Convert.ToBoolean(dictionary_0[getString_0(107378238)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107378257)))
		{
			dSpBPGMHkvPOFvi();
			nEKyzGsocBv = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107378317)) && !dictionary_0.ContainsKey(getString_0(107378308)))
		{
			Console.WriteLine(getString_0(107378216));
			dSpBPGMHkvPOFvi();
			nEKyzGsocBv = null;
		}
		return nEKyzGsocBv;
	}

	public static bool ASMQZPHpnMlFm(NEKyzGsocBv nekyzGsocBv_0)
	{
		return true;
	}

	public static void dSpBPGMHkvPOFvi()
	{
	}

	static bUvPIoeMNAAwV()
	{
		Strings.CreateGetStringDelegate(typeof(bUvPIoeMNAAwV));
	}
}
