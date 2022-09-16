using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace F0;

internal class sA
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int oA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int NK;

	private static sA xZ;

	[SpecialName]
	[CompilerGenerated]
	public int zi()
	{
		return oA;
	}

	[SpecialName]
	[CompilerGenerated]
	private void rk(int int_0)
	{
		oA = int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int ET()
	{
		return NK;
	}

	[SpecialName]
	[CompilerGenerated]
	private void xJ(int int_0)
	{
		NK = int_0;
	}

	public sA(int int_0, int int_1)
	{
		Rg.XRF6rz();
		base._002Ector();
		rk(int_0);
		xJ(int_1);
	}

	internal static bool W9()
	{
		return xZ == null;
	}

	internal static sA TL()
	{
		return xZ;
	}
}
