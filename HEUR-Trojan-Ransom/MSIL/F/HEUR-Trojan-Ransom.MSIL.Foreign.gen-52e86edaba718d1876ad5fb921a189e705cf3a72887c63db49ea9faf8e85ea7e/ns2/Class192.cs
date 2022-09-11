using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns2;

[CompilerGenerated]
internal sealed class Class192
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 6)]
	private struct Struct32
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
	private struct Struct33
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 12)]
	private struct Struct34
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 15)]
	private struct Struct35
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct36
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct Struct37
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 24)]
	private struct Struct38
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 26)]
	private struct Struct39
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	private struct Struct40
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48)]
	private struct Struct41
	{
	}

	internal static readonly Struct36 struct36_0/* Not supported: data(99 79 82 5A A1 EB D9 6E DC BC 1B 8F D6 C1 62 CA) */;

	internal static readonly Struct38 struct38_0/* Not supported: data(06 00 00 00 0F 00 00 00 10 00 00 00 0B 00 00 00 12 00 00 00 00 00 00 00) */;

	internal static readonly Struct38 struct38_1/* Not supported: data(2D 2D 2D 2D 2D 45 4E 44 20 50 55 42 4C 49 43 20 4B 45 59 2D 2D 2D 2D 2D) */;

	internal static readonly Struct34 struct34_0/* Not supported: data(03 00 00 00 0D 00 00 00 09 00 00 00) */;

	internal static readonly Struct38 struct38_2/* Not supported: data(FC 00 00 00 F9 00 00 00 FA 00 00 00 FB 00 00 00 58 02 00 00 59 02 00 00) */;

	internal static readonly Struct34 struct34_1/* Not supported: data(28 00 00 00 29 00 00 00 44 00 00 00) */;

	internal static readonly Struct39 struct39_0/* Not supported: data(2D 2D 2D 2D 2D 42 45 47 49 4E 20 50 55 42 4C 49 43 20 4B 45 59 2D 2D 2D 2D 2D) */;

	internal static readonly Struct32 struct32_0/* Not supported: data(2C 00 7D 00 5D 00) */;

	internal static readonly Struct38 struct38_3/* Not supported: data(1E 00 00 00 1D 00 00 00 20 00 00 00 1F 00 00 00 1B 00 00 00 1C 00 00 00) */;

	internal static readonly Struct33 struct33_0/* Not supported: data(28 00 22 00 40 00 27 00 60 00) */;

	internal static readonly Struct37 struct37_0/* Not supported: data(01 23 45 67 89 AB CD EF FE DC BA 98 76 54 32 10 F0 E1 D2 C3) */;

	internal static readonly Struct34 struct34_2/* Not supported: data(0A 00 00 00 0C 00 00 00 07 00 00 00) */;

	internal static readonly Struct40 struct40_0/* Not supported: data(FE 00 00 00 FE 00 00 00 FD 00 00 00 FD 00 00 00 F8 00 00 00 F7 00 00 00 ED 02 00 00 F0 02 00 00 EE 02 00 00 EF 02 00 00) */;

	internal static readonly Struct33 struct33_1/* Not supported: data(2D 00 20 00 3A 00 2F 00 2E 00) */;

	internal static readonly Struct35 struct35_0/* Not supported: data(30 0D 06 09 2A 86 48 86 F7 0D 01 01 01 05 00) */;

	internal static readonly Struct34 struct34_3/* Not supported: data(21 00 00 00 22 00 00 00 23 00 00 00) */;

	internal static readonly Struct41 struct41_0/* Not supported: data(FF FF 00 00 00 00 00 00 FF 00 00 00 00 00 00 00 FF FF FF 00 00 00 00 00 FF FF FF FF 00 00 00 00 FF 00 00 00 00 00 00 00 FF FF 00 00 00 00 00 00) */;

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
