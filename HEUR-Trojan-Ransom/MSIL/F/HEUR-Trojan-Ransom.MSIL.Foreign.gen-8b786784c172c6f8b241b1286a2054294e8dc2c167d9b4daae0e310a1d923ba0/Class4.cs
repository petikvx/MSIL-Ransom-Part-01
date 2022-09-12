using System.Runtime.InteropServices;

internal sealed class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct Struct0
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 26)]
	private struct Struct1
	{
	}

	internal static readonly Struct0 struct0_0/* Not supported: data(23 27 00 00 A8 DE 00 00 C2 88 00 00 DA BA 00 00 F1 80 00 00) */;

	internal static readonly Struct1 struct1_0/* Not supported: data(73 77 69 73 73 61 63 63 6F 75 6E 74 2E 64 64 6E 73 2E 6E 65 74 00 00 00 00 00) */;

	internal static uint smethod_0(string string_0)
	{
		uint num = default(uint);
		if (string_0 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < string_0.Length; i++)
			{
				num = (string_0[i] ^ num) * 16777619;
			}
		}
		return num;
	}
}
