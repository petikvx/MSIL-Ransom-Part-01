using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

internal sealed class cvbwyAOsjCIrtCV
{
	public sealed class FSbdMmmerVmhS
	{
		public bool uOzTjfbCehn;

		public bool lCaNWTZPztWKr;

		public bool ptcujmtRVb;

		public int zVxqjdcbnehChkIU = 25;

		public List<string> mxMAjemEgAgq = new List<string>
		{
			getString_0(107401774),
			getString_0(107401765),
			getString_0(107390675),
			getString_0(107401784)
		};

		public string MwlGTNguIkUjL;

		public string CqHyItYUGeMevo;

		public string toNcJPnAMT;

		public string WJboIaHxMxjcJt;

		public string bRhrUQawnBI;

		public string aRGWfhajqEuB;

		[NonSerialized]
		internal static GetString getString_0;

		static FSbdMmmerVmhS()
		{
			Strings.CreateGetStringDelegate(typeof(FSbdMmmerVmhS));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> IrNjDSmgnfNfa(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107401516).ToCharArray(), 2);
			list.Add(array[0]);
			if (array.Length == 1)
			{
				dictionary[array[0]] = new string[1] { getString_0(107397309) };
			}
			if (array.Length == 2)
			{
				dictionary[array[0]] = new string[1] { array[1] };
			}
		}
		return dictionary;
	}

	public static FSbdMmmerVmhS XNzhOlOXDBONQa(Dictionary<string, string[]> dictionary_0)
	{
		FSbdMmmerVmhS fSbdMmmerVmhS = new FSbdMmmerVmhS();
		if (dictionary_0.ContainsKey(getString_0(107401511)))
		{
			fSbdMmmerVmhS.MwlGTNguIkUjL = dictionary_0[getString_0(107401511)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107401474)))
		{
			fSbdMmmerVmhS.CqHyItYUGeMevo = dictionary_0[getString_0(107401474)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107401493)))
		{
			fSbdMmmerVmhS.mxMAjemEgAgq = dictionary_0[getString_0(107401493)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107401480)))
		{
			fSbdMmmerVmhS.toNcJPnAMT = dictionary_0[getString_0(107401480)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107401951)))
		{
			fSbdMmmerVmhS.WJboIaHxMxjcJt = dictionary_0[getString_0(107401951)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107401946)))
		{
			fSbdMmmerVmhS.bRhrUQawnBI = dictionary_0[getString_0(107401946)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107401965)))
		{
			fSbdMmmerVmhS.uOzTjfbCehn = Convert.ToBoolean(dictionary_0[getString_0(107401965)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107401920)))
		{
			fSbdMmmerVmhS.aRGWfhajqEuB = dictionary_0[getString_0(107401920)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107401939)))
		{
			fSbdMmmerVmhS.zVxqjdcbnehChkIU = Convert.ToInt32(dictionary_0[getString_0(107401939)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107401894)))
		{
			fSbdMmmerVmhS.lCaNWTZPztWKr = Convert.ToBoolean(dictionary_0[getString_0(107401894)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107401881)))
		{
			fSbdMmmerVmhS.ptcujmtRVb = Convert.ToBoolean(dictionary_0[getString_0(107401881)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107401900)))
		{
			XddawkhjOeZzNF();
			fSbdMmmerVmhS = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107401480)) && !dictionary_0.ContainsKey(getString_0(107401951)))
		{
			Console.WriteLine(getString_0(107401859));
			XddawkhjOeZzNF();
			fSbdMmmerVmhS = null;
		}
		return fSbdMmmerVmhS;
	}

	public static bool dodlyDkZmoGywF(FSbdMmmerVmhS fsbdMmmerVmhS_0)
	{
		return true;
	}

	public static void XddawkhjOeZzNF()
	{
	}

	static cvbwyAOsjCIrtCV()
	{
		Strings.CreateGetStringDelegate(typeof(cvbwyAOsjCIrtCV));
	}
}
