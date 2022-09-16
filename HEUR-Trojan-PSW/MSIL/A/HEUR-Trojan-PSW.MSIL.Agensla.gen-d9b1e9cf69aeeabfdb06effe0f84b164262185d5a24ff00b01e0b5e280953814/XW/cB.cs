using System.Runtime.CompilerServices;

namespace XW;

public static class cB
{
	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void kLk<jo>(ref jo gparam_0, ref jo gparam_1)
	{
		jo val = gparam_0;
		gparam_0 = gparam_1;
		gparam_1 = val;
	}
}
