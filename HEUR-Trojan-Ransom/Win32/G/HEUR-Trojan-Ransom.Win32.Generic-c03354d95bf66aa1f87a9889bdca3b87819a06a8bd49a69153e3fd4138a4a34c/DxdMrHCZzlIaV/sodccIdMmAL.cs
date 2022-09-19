using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DxdMrHCZzlIaV;

public sealed class sodccIdMmAL
{
	private string hzYFHAlOBWErW;

	private ulong jCeICSKRcOTwAwK;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => hzYFHAlOBWErW;

	public ulong ParentFrn => jCeICSKRcOTwAwK;

	public sodccIdMmAL(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107351395), getString_0(107351342));
		}
		hzYFHAlOBWErW = string_0;
		jCeICSKRcOTwAwK = ulong_0;
	}

	static sodccIdMmAL()
	{
		Strings.CreateGetStringDelegate(typeof(sodccIdMmAL));
	}
}
