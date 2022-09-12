using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[CompilerGenerated]
internal sealed class EF83A0392
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
	private struct A4F632CBD
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct A746F6C94
	{
	}

	internal static readonly A746F6C94 F83DFBD43/* Not supported: data(13 00 00 00 12 00 00 00 19 00 00 00 1A 00 00 00) */;

	internal static readonly A4F632CBD F044824FC/* Not supported: data(22 00 00 00 23 00 00 00 27 00 00 00) */;

	internal static readonly A4F632CBD DA53EF169/* Not supported: data(28 00 00 00 29 00 00 00 2A 00 00 00) */;

	internal static uint B0B7CE4F9(string A74872269)
	{
		uint num = default(uint);
		if (A74872269 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < A74872269.Length; i++)
			{
				num = (A74872269[i] ^ num) * 16777619;
			}
		}
		return num;
	}
}
