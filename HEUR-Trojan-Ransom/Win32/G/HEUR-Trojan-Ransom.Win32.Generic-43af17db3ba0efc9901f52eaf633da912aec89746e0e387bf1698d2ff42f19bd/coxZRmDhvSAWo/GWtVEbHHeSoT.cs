using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

internal sealed class GWtVEbHHeSoT
{
	public sealed class DreBjpmCbgKhJ
	{
		public bool VIZSDZOANmyxVY = false;

		public bool KmSydxxoGHgBZ = false;

		public bool TTlBKiKDklJg = false;

		public bool JecNQukvRkEHsFUl = false;

		public int IeqSEttefCWKQHvP = 25;

		public List<string> smWXbICUUTvJslJG = new List<string>
		{
			getString_0(107364502),
			getString_0(107364493),
			getString_0(107388252),
			getString_0(107364512)
		};

		public string ZgWAkHyWax = null;

		public string jZopHdHfoIv = null;

		public string wyJYzdRFYFlpW = null;

		public string wFfmdhGHbmBS = null;

		public string PblgOpjjEhilAD = null;

		public string ZqZPxgJYdTUZS = null;

		[NonSerialized]
		internal static GetString getString_0;

		static DreBjpmCbgKhJ()
		{
			Strings.CreateGetStringDelegate(typeof(DreBjpmCbgKhJ));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> dTENyBRHBINs(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		string[] array = new string[3]
		{
			getString_0(107364243),
			getString_0(107364198),
			getString_0(107364217)
		};
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array2 = text.Split(getString_0(107364172).ToCharArray(), 2);
			list.Add(array2[0]);
			if (array2.Length == 1)
			{
				dictionary[array2[0]] = new string[1] { getString_0(107396391) };
			}
			if (array2.Length == 2)
			{
				dictionary[array2[0]] = new string[1] { array2[1] };
			}
		}
		return dictionary;
	}

	public static DreBjpmCbgKhJ VRcbYwVjOdVywh(Dictionary<string, string[]> dictionary_0)
	{
		DreBjpmCbgKhJ dreBjpmCbgKhJ = new DreBjpmCbgKhJ();
		if (dictionary_0.ContainsKey(getString_0(107364167)))
		{
			dreBjpmCbgKhJ.ZgWAkHyWax = dictionary_0[getString_0(107364167)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107364162)))
		{
			dreBjpmCbgKhJ.jZopHdHfoIv = dictionary_0[getString_0(107364162)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107364181)))
		{
			dreBjpmCbgKhJ.smWXbICUUTvJslJG = dictionary_0[getString_0(107364181)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107364136)))
		{
			dreBjpmCbgKhJ.wyJYzdRFYFlpW = dictionary_0[getString_0(107364136)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107364159)))
		{
			dreBjpmCbgKhJ.wFfmdhGHbmBS = dictionary_0[getString_0(107364159)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107364154)))
		{
			dreBjpmCbgKhJ.PblgOpjjEhilAD = dictionary_0[getString_0(107364154)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107364243)))
		{
			dreBjpmCbgKhJ.KmSydxxoGHgBZ = Convert.ToBoolean(dictionary_0[getString_0(107364243)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107364621)))
		{
			dreBjpmCbgKhJ.ZqZPxgJYdTUZS = dictionary_0[getString_0(107364621)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107364608)))
		{
			dreBjpmCbgKhJ.IeqSEttefCWKQHvP = Convert.ToInt32(dictionary_0[getString_0(107364608)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107364198)))
		{
			dreBjpmCbgKhJ.TTlBKiKDklJg = Convert.ToBoolean(dictionary_0[getString_0(107364198)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107364217)))
		{
			dreBjpmCbgKhJ.JecNQukvRkEHsFUl = Convert.ToBoolean(dictionary_0[getString_0(107364217)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107364627)))
		{
			JSnrWvEYMyxtesqwp();
			dreBjpmCbgKhJ = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107364136)) && !dictionary_0.ContainsKey(getString_0(107364159)))
		{
			Console.WriteLine(getString_0(107364586));
			JSnrWvEYMyxtesqwp();
			dreBjpmCbgKhJ = null;
		}
		return dreBjpmCbgKhJ;
	}

	public static bool miqbVsDpsDYI(DreBjpmCbgKhJ dreBjpmCbgKhJ_0)
	{
		return true;
	}

	public static void JSnrWvEYMyxtesqwp()
	{
	}

	static GWtVEbHHeSoT()
	{
		Strings.CreateGetStringDelegate(typeof(GWtVEbHHeSoT));
	}
}
