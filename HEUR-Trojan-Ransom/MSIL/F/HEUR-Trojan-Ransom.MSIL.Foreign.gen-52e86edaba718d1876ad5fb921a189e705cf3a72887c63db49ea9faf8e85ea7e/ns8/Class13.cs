using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns8;

[CompilerGenerated]
internal sealed class Class13
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 14)]
	private struct Struct2
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct Struct3
	{
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 202)]
	private struct Struct4
	{
	}

	internal static readonly Struct3 struct3_0/* Not supported: data(A1 0D 00 00 C2 26 00 00 61 4F 00 00 59 00 00 00 47 00 00 00) */;

	internal static readonly Struct4 struct4_0/* Not supported: data(62 64 73 73 3D 42 2E 44 65 66 2C 6F 6E 6C 69 6E 65 6E 74 3D 51 2D 48 41 4C 2C 62 64 61 67 65 6E 74 3D 42 44 41 67 65 6E 74 2C 6D 73 73 65 63 65 73 3D 4D 53 20 45 73 73 65 6E 74 69 61 6C 73 2C 66 73 73 6D 33 32 3D 46 53 65 63 75 72 65 2C 61 76 70 3D 4B 61 73 70 65 72 73 6B 79 2C 61 76 67 6E 74 3D 41 76 69 72 61 2C 73 70 62 62 63 73 76 63 3D 53 79 6D 61 6E 74 65 63 2C 75 70 64 61 74 65 72 75 69 3D 4D 63 41 66 65 65 2C 61 76 67 75 69 3D 41 56 47 2C 61 76 67 63 63 3D 41 56 47 2C 6D 62 61 6D 3D 41 6E 74 20 4D 61 6C 77 61 72 65 2C 61 76 61 73 74 75 69 3D 41 76 61 73 74 2C 61 76 61 73 74 3D 41 76 61 73 74) */;

	internal static readonly Struct2 struct2_0/* Not supported: data(31 38 35 2E 31 34 30 2E 35 33 2E 32 32 31) */;

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
