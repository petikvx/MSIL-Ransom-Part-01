using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace LHzwFzfXBAR;

public sealed class dfiDGXicFqh
{
	private string vAColOtcjnu;

	private ulong NGxYAemXEUTHCu;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => vAColOtcjnu;

	public ulong ParentFrn => NGxYAemXEUTHCu;

	public dfiDGXicFqh(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107474496), getString_0(107474411));
		}
		vAColOtcjnu = string_0;
		NGxYAemXEUTHCu = ulong_0;
	}

	static dfiDGXicFqh()
	{
		Strings.CreateGetStringDelegate(typeof(dfiDGXicFqh));
	}
}
