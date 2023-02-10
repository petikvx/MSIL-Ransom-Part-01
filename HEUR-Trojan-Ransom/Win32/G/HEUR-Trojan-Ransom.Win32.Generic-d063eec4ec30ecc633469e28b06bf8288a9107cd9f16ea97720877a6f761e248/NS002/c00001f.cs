using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NS002;

public sealed class c00001f
{
	private string WZyywNYnYkm;

	private ulong qfxQBHcyZUmu;

	[NonSerialized]
	internal static GetString f00005a;

	public string Name => WZyywNYnYkm;

	public ulong ParentFrn => qfxQBHcyZUmu;

	public c00001f(string p0, ulong p1)
	{
		if (p0 == null || p0.Length <= 0)
		{
			throw new ArgumentException("Invalid argument: null or Length = zero", "name");
		}
		WZyywNYnYkm = p0;
		qfxQBHcyZUmu = p1;
	}

	static c00001f()
	{
		Strings.CreateGetStringDelegate(typeof(c00001f));
	}
}
