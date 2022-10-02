using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bFWwXrIbhEFQiaW;

public sealed class TBzXjPONBCkB
{
	private string phokodIGTspkd;

	private ulong NoztwtwADR;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => phokodIGTspkd;

	public ulong ParentFrn => NoztwtwADR;

	public TBzXjPONBCkB(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107461410), getString_0(107461357));
		}
		phokodIGTspkd = string_0;
		NoztwtwADR = ulong_0;
	}

	static TBzXjPONBCkB()
	{
		Strings.CreateGetStringDelegate(typeof(TBzXjPONBCkB));
	}
}
