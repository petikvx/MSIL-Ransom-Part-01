using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

internal sealed class mgfLHdPEFNpYee
{
	public sealed class iIzVwqDPrWThf
	{
		public bool gcFyyblGqX;

		public bool GcORuzmVZcHz;

		public bool BUTDeeZsqU;

		public int ZKumpgvgOVOtdZ = 25;

		public List<string> HFSgkjkNPzYvbv = new List<string>
		{
			getString_0(107398850),
			getString_0(107398809),
			getString_0(107388981),
			getString_0(107398796)
		};

		public string PVtfjIiylTyEf;

		public string KEIKhBbfDVwr;

		public string LLYwNvYMPst;

		public string KHkcMKKEBghT;

		public string VkLpGXIjXjs;

		public string igJtUrQqFr;

		[NonSerialized]
		internal static GetString getString_0;

		static iIzVwqDPrWThf()
		{
			Strings.CreateGetStringDelegate(typeof(iIzVwqDPrWThf));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> PiLOhqXZWXU(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107398528).ToCharArray(), 2);
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

	public static iIzVwqDPrWThf SWiXHvMeYbS(Dictionary<string, string[]> dictionary_0)
	{
		iIzVwqDPrWThf iIzVwqDPrWThf = new iIzVwqDPrWThf();
		if (dictionary_0.ContainsKey(getString_0(107398555)))
		{
			iIzVwqDPrWThf.PVtfjIiylTyEf = dictionary_0[getString_0(107398555)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107398550)))
		{
			iIzVwqDPrWThf.KEIKhBbfDVwr = dictionary_0[getString_0(107398550)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107398505)))
		{
			iIzVwqDPrWThf.HFSgkjkNPzYvbv = dictionary_0[getString_0(107398505)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107398524)))
		{
			iIzVwqDPrWThf.LLYwNvYMPst = dictionary_0[getString_0(107398524)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107398515)))
		{
			iIzVwqDPrWThf.KHkcMKKEBghT = dictionary_0[getString_0(107398515)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107398510)))
		{
			iIzVwqDPrWThf.VkLpGXIjXjs = dictionary_0[getString_0(107398510)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107398465)))
		{
			iIzVwqDPrWThf.gcFyyblGqX = Convert.ToBoolean(dictionary_0[getString_0(107398465)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107398484)))
		{
			iIzVwqDPrWThf.igJtUrQqFr = dictionary_0[getString_0(107398484)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107398439)))
		{
			iIzVwqDPrWThf.ZKumpgvgOVOtdZ = Convert.ToInt32(dictionary_0[getString_0(107398439)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107398458)))
		{
			iIzVwqDPrWThf.GcORuzmVZcHz = Convert.ToBoolean(dictionary_0[getString_0(107398458)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107398413)))
		{
			iIzVwqDPrWThf.BUTDeeZsqU = Convert.ToBoolean(dictionary_0[getString_0(107398413)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107398400)))
		{
			mmRkzXVJARfp();
			iIzVwqDPrWThf = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107398524)) && !dictionary_0.ContainsKey(getString_0(107398515)))
		{
			Console.WriteLine(getString_0(107398423));
			mmRkzXVJARfp();
			iIzVwqDPrWThf = null;
		}
		return iIzVwqDPrWThf;
	}

	public static bool eDlwDIUBmKmr(iIzVwqDPrWThf iIzVwqDPrWThf_0)
	{
		return true;
	}

	public static void mmRkzXVJARfp()
	{
	}

	static mgfLHdPEFNpYee()
	{
		Strings.CreateGetStringDelegate(typeof(mgfLHdPEFNpYee));
	}
}
