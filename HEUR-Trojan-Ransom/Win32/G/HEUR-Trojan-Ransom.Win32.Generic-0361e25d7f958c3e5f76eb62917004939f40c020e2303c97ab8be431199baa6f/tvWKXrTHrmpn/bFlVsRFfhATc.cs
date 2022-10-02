using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace tvWKXrTHrmpn;

public sealed class bFlVsRFfhATc
{
	private string TIEMVnHeitEiHNuwt;

	private ulong eEXxrVbbzkVhF;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => TIEMVnHeitEiHNuwt;

	public ulong ParentFrn => eEXxrVbbzkVhF;

	public bFlVsRFfhATc(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107462577), getString_0(107462556));
		}
		TIEMVnHeitEiHNuwt = string_0;
		eEXxrVbbzkVhF = ulong_0;
	}

	static bFlVsRFfhATc()
	{
		Strings.CreateGetStringDelegate(typeof(bFlVsRFfhATc));
	}
}
