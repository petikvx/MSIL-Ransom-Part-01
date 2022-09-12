using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EbNNdTmxNaUt;

public sealed class gscyLTjmBf
{
	private string rxZzpeOQGtQoWwYL;

	private ulong ayAFqJfBwKlDH;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => rxZzpeOQGtQoWwYL;

	public ulong ParentFrn => ayAFqJfBwKlDH;

	public gscyLTjmBf(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107364653), getString_0(107365112));
		}
		rxZzpeOQGtQoWwYL = string_0;
		ayAFqJfBwKlDH = ulong_0;
	}

	static gscyLTjmBf()
	{
		Strings.CreateGetStringDelegate(typeof(gscyLTjmBf));
	}
}
