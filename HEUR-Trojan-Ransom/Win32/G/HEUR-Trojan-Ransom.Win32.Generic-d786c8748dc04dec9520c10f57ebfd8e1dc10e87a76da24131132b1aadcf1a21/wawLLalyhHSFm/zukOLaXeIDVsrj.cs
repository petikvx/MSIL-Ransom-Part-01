using System;
using System.Collections.Generic;
using System.Linq;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

internal sealed class zukOLaXeIDVsrj
{
	public sealed class cSVJqSKpvLR
	{
		public bool nGnFSgaVXcXH;

		public bool aQtxqGzpQKk;

		public bool SqAvfvxykGb;

		public int WsxNlAHvWSEeHP = 25;

		public List<string> EJGUpkTebTaIUTvMn = new List<string>
		{
			getString_0(107397870),
			getString_0(107397893),
			getString_0(107388746),
			getString_0(107397848)
		};

		public string csRaQdZyyT;

		public string oBCerHfHgy;

		public string uzAkXXWHsJGGtl;

		public string JnzFGkhqdx;

		public string rhiRChpQWa;

		public string vnnFLBuFszUy;

		[NonSerialized]
		internal static GetString getString_0;

		static cSVJqSKpvLR()
		{
			Strings.CreateGetStringDelegate(typeof(cSVJqSKpvLR));
		}
	}

	[NonSerialized]
	internal static GetString getString_0;

	public static Dictionary<string, string[]> gLXfHZWRUpBXqRTW(string[] string_0)
	{
		Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
		List<string> list = new List<string>();
		foreach (string text in string_0)
		{
			string[] array = text.Split(getString_0(107397580).ToCharArray(), 2);
			list.Add(array[0]);
			if (array.Length == 1)
			{
				dictionary[array[0]] = new string[1] { getString_0(107397215) };
			}
			if (array.Length == 2)
			{
				dictionary[array[0]] = new string[1] { array[1] };
			}
		}
		return dictionary;
	}

	public static cSVJqSKpvLR DqaqcSRZrEjC(Dictionary<string, string[]> dictionary_0)
	{
		cSVJqSKpvLR cSVJqSKpvLR = new cSVJqSKpvLR();
		if (dictionary_0.ContainsKey(getString_0(107397575)))
		{
			cSVJqSKpvLR.csRaQdZyyT = dictionary_0[getString_0(107397575)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107397570)))
		{
			cSVJqSKpvLR.oBCerHfHgy = dictionary_0[getString_0(107397570)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107397589)))
		{
			cSVJqSKpvLR.EJGUpkTebTaIUTvMn = dictionary_0[getString_0(107397589)][0].ToUpper().Split(new char[1] { ',' }).ToList();
		}
		if (dictionary_0.ContainsKey(getString_0(107397544)))
		{
			cSVJqSKpvLR.uzAkXXWHsJGGtl = dictionary_0[getString_0(107397544)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107397535)))
		{
			cSVJqSKpvLR.JnzFGkhqdx = dictionary_0[getString_0(107397535)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107397562)))
		{
			cSVJqSKpvLR.rhiRChpQWa = dictionary_0[getString_0(107397562)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107397549)))
		{
			cSVJqSKpvLR.nGnFSgaVXcXH = Convert.ToBoolean(dictionary_0[getString_0(107397549)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107397504)))
		{
			cSVJqSKpvLR.vnnFLBuFszUy = dictionary_0[getString_0(107397504)][0];
		}
		if (dictionary_0.ContainsKey(getString_0(107397523)))
		{
			cSVJqSKpvLR.WsxNlAHvWSEeHP = Convert.ToInt32(dictionary_0[getString_0(107397523)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107397478)))
		{
			cSVJqSKpvLR.aQtxqGzpQKk = Convert.ToBoolean(dictionary_0[getString_0(107397478)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107397497)))
		{
			cSVJqSKpvLR.SqAvfvxykGb = Convert.ToBoolean(dictionary_0[getString_0(107397497)][0]);
		}
		if (dictionary_0.ContainsKey(getString_0(107397452)))
		{
			AQhsgJGbekh();
			cSVJqSKpvLR = null;
		}
		if (!dictionary_0.ContainsKey(getString_0(107397544)) && !dictionary_0.ContainsKey(getString_0(107397535)))
		{
			Console.WriteLine(getString_0(107397443));
			AQhsgJGbekh();
			cSVJqSKpvLR = null;
		}
		return cSVJqSKpvLR;
	}

	public static bool CLGOXFtRVRqZhlY(cSVJqSKpvLR cSVJqSKpvLR_0)
	{
		return true;
	}

	public static void AQhsgJGbekh()
	{
	}

	static zukOLaXeIDVsrj()
	{
		Strings.CreateGetStringDelegate(typeof(zukOLaXeIDVsrj));
	}
}
