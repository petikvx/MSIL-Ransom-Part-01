using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

internal sealed class HkJcjpzBEEOnh
{
	public sealed class NEKyzGsocBv
	{
		public bool ksnogyPuQh;

		public bool niYVXBafZsNVAo;

		public bool AEiwHlLfOBSK;

		public int NDzgRiqaaBg = 25;

		public List<string> PestXWGbVnp = new List<string>
		{
			getString_0(107376567),
			getString_0(107376558),
			getString_0(107400516),
			getString_0(107376577)
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

	public static Dictionary<string, string[]> SRnJcgYmzltgJB(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107377333).ToCharArray(), 2);
			list.Add(array[0]);
			if (array.Length == 1)
			{
				dictionary[array[0]] = new string[1] { getString_0(107397284) };
			}
			if (array.Length == 2)
			{
				dictionary[array[0]] = new string[1] { array[1] };
			}
		}
		return dictionary;
	}

	public static NEKyzGsocBv BZhqDSMGmctj(Dictionary<string, string[]> dictionary_0)
	{
		NEKyzGsocBv nEKyzGsocBv = new NEKyzGsocBv();
		if (dictionary_0.ContainsKey(getString_0(107377328)))
		{
			nEKyzGsocBv.IFQXsrdSniBZVI = dictionary_0[getString_0(107377328)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377291)))
		{
			nEKyzGsocBv.HKOFImfkdtwJ = dictionary_0[getString_0(107377291)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377278)))
		{
			nEKyzGsocBv.PestXWGbVnp = dictionary_0[getString_0(107377278)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107377297)))
		{
			nEKyzGsocBv.GRSCvqmVTCdpPEKJ = dictionary_0[getString_0(107377297)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377256)))
		{
			nEKyzGsocBv.AsuHoZmUdixtqe = dictionary_0[getString_0(107377256)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377251)))
		{
			nEKyzGsocBv.wYvAGVrLdVxju = dictionary_0[getString_0(107377251)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377270)))
		{
			nEKyzGsocBv.ksnogyPuQh = Convert.ToBoolean(dictionary_0[getString_0(107377270)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377225)))
		{
			nEKyzGsocBv.HpZsojMbNHWAb = dictionary_0[getString_0(107377225)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107377244)))
		{
			nEKyzGsocBv.NDzgRiqaaBg = Convert.ToInt32(dictionary_0[getString_0(107377244)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377231)))
		{
			nEKyzGsocBv.niYVXBafZsNVAo = Convert.ToBoolean(dictionary_0[getString_0(107377231)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377186)))
		{
			nEKyzGsocBv.AEiwHlLfOBSK = Convert.ToBoolean(dictionary_0[getString_0(107377186)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107377205)))
		{
			WVjsyPUvpiyFyEZ();
			nEKyzGsocBv = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107377297)) && !dictionary_0.ContainsKey(getString_0(107377256)))
		{
			Console.WriteLine(getString_0(107376652));
			WVjsyPUvpiyFyEZ();
			nEKyzGsocBv = null;
		}
		return nEKyzGsocBv;
	}

	public static bool mcGDMZHobnhL(NEKyzGsocBv nekyzGsocBv_0)
	{
		return true;
	}

	public static void WVjsyPUvpiyFyEZ()
	{
	}

	static HkJcjpzBEEOnh()
	{
		Strings.CreateGetStringDelegate(typeof(HkJcjpzBEEOnh));
	}
}
