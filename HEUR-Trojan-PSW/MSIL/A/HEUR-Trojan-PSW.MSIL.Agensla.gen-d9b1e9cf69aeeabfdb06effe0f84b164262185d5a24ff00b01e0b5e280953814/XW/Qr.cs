using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace XW;

[AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false)]
public sealed class Qr : Attribute
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string XiZ;

	internal static Qr Cq1;

	[SpecialName]
	[CompilerGenerated]
	public string giJ()
	{
		return XiZ;
	}

	[SpecialName]
	[CompilerGenerated]
	private void li9(string string_0)
	{
		XiZ = string_0;
	}

	public Qr(string string_0)
	{
		G3.nJ(G3.By);
		base._002Ector();
		Ew.nJ(this, string_0, Ew.WuX);
	}

	internal static bool aq0()
	{
		return Cq1 == null;
	}

	internal static Qr LqW()
	{
		return Cq1;
	}
}
