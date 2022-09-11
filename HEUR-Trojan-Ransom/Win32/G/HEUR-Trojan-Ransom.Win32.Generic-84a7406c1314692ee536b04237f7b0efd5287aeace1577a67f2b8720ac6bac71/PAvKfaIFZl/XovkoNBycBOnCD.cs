using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace PAvKfaIFZl;

public sealed class XovkoNBycBOnCD
{
	private string PhcDUkPTlwb;

	private ulong OlEEUjgsiW;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => PhcDUkPTlwb;

	public ulong ParentFrn => OlEEUjgsiW;

	public XovkoNBycBOnCD(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107408716), getString_0(107408631));
		}
		PhcDUkPTlwb = string_0;
		OlEEUjgsiW = ulong_0;
	}

	static XovkoNBycBOnCD()
	{
		Strings.CreateGetStringDelegate(typeof(XovkoNBycBOnCD));
	}
}
