using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace LHzwFzfXBAR;

public sealed class hGdahdRUOgSYh
{
	private string vAColOtcjnu;

	private ulong NGxYAemXEUTHCu;

	[NonSerialized]
	internal static GetString getString_0;

	public string Name => vAColOtcjnu;

	public ulong ParentFrn => NGxYAemXEUTHCu;

	public hGdahdRUOgSYh(string string_0, ulong ulong_0)
	{
		if (string_0 == null || string_0.Length <= 0)
		{
			throw new ArgumentException(getString_0(107476423), getString_0(107475826));
		}
		vAColOtcjnu = string_0;
		NGxYAemXEUTHCu = ulong_0;
	}

	static hGdahdRUOgSYh()
	{
		Strings.CreateGetStringDelegate(typeof(hGdahdRUOgSYh));
	}
}
