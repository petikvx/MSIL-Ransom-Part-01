using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

internal sealed class CloxxHDYIiDnH
{
	public sealed class mtofTxzGXYEyJ
	{
		public bool HPxCySWvQlUiA = false;

		public bool mlPhTnFwtlWNeMduzv = false;

		public bool UuXwrxqyTVvG = false;

		public bool gGcZJcaAZjhD = false;

		public int HmjfHrzPbYuL = 25;

		public List<string> EnyefEsEjePkew = new List<string>
		{
			getString_0(107407043),
			getString_0(107407002),
			getString_0(107388035),
			getString_0(107407021)
		};

		public string jmVpgEmwoA = null;

		public string HJjxRwvauSz = null;

		public string majXkJbUDNvi = null;

		public string KeNodwUlUHvzAR = null;

		public string gbszAcFlnSwKvyE = null;

		public string yclMYJkBWXLHn = null;

		[NonSerialized]
		internal static GetString getString_0;

		static mtofTxzGXYEyJ()
		{
			Strings.CreateGetStringDelegate(typeof(mtofTxzGXYEyJ));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> xWTsAfEUXLxkdRv(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		string[] array = new string[3]
		{
			getString_0(107406752),
			getString_0(107406707),
			getString_0(107406694)
		};
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array2 = text.Split(getString_0(107406713).ToCharArray(), 2);
			list.Add(array2[0]);
			if (array2.Length == 1)
			{
				dictionary[array2[0]] = new string[1] { getString_0(107396621) };
			}
			if (array2.Length == 2)
			{
				dictionary[array2[0]] = new string[1] { array2[1] };
			}
		}
		return dictionary;
	}

	public static mtofTxzGXYEyJ vNwYthxwtf(Dictionary<string, string[]> dictionary_0)
	{
		mtofTxzGXYEyJ mtofTxzGXYEyJ = new mtofTxzGXYEyJ();
		if (dictionary_0.ContainsKey(getString_0(107406676)))
		{
			mtofTxzGXYEyJ.jmVpgEmwoA = dictionary_0[getString_0(107406676)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107406671)))
		{
			mtofTxzGXYEyJ.HJjxRwvauSz = dictionary_0[getString_0(107406671)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107406690)))
		{
			mtofTxzGXYEyJ.EnyefEsEjePkew = dictionary_0[getString_0(107406690)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107406677)))
		{
			mtofTxzGXYEyJ.majXkJbUDNvi = dictionary_0[getString_0(107406677)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107406636)))
		{
			mtofTxzGXYEyJ.KeNodwUlUHvzAR = dictionary_0[getString_0(107406636)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107406631)))
		{
			mtofTxzGXYEyJ.gbszAcFlnSwKvyE = dictionary_0[getString_0(107406631)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107406752)))
		{
			mtofTxzGXYEyJ.mlPhTnFwtlWNeMduzv = Convert.ToBoolean(dictionary_0[getString_0(107406752)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107406650)))
		{
			mtofTxzGXYEyJ.yclMYJkBWXLHn = dictionary_0[getString_0(107406650)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107407117)))
		{
			mtofTxzGXYEyJ.HmjfHrzPbYuL = Convert.ToInt32(dictionary_0[getString_0(107407117)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107406707)))
		{
			mtofTxzGXYEyJ.UuXwrxqyTVvG = Convert.ToBoolean(dictionary_0[getString_0(107406707)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107406694)))
		{
			mtofTxzGXYEyJ.gGcZJcaAZjhD = Convert.ToBoolean(dictionary_0[getString_0(107406694)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107407136)))
		{
			IkZitJGjLQDpG();
			mtofTxzGXYEyJ = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107406677)) && !dictionary_0.ContainsKey(getString_0(107406636)))
		{
			Console.WriteLine(getString_0(107407127));
			IkZitJGjLQDpG();
			mtofTxzGXYEyJ = null;
		}
		return mtofTxzGXYEyJ;
	}

	public static bool vOkIsCuVxIbg(mtofTxzGXYEyJ mtofTxzGXYEyJ_0)
	{
		return true;
	}

	public static void IkZitJGjLQDpG()
	{
	}

	static CloxxHDYIiDnH()
	{
		Strings.CreateGetStringDelegate(typeof(CloxxHDYIiDnH));
	}
}
