using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gSIYQHSVYK;

public sealed class RTVnWQrlpyAp
{
	private string leieAYDersAS;

	private ulong zsVrHoqRwVoA;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => leieAYDersAS;

	public ulong ParentFrn => zsVrHoqRwVoA;

	public RTVnWQrlpyAp(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107365398), getString_0(107364801));
		}
		leieAYDersAS = string_0;
		zsVrHoqRwVoA = ulong_0;
	}

	static RTVnWQrlpyAp()
	{
		Strings.CreateGetStringDelegate(typeof(RTVnWQrlpyAp));
	}
}
