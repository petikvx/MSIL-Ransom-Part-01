using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using iLd730DL;
using iiraiv39;

namespace ZqaFD1Ap;

[CompilerGenerated]
internal sealed class PG9QGTIa
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 5)]
	private struct Struct1
	{
	}

	internal static readonly Struct1 UTEq8ago/* Not supported: data(01 00 00 01 01) */;

	internal static uint vqcqF5n9(string twTYKVhR)
	{
		uint num = 2166136261u;
		if (twTYKVhR != null)
		{
			for (int i = 0; i < ivlgLlId.f5lHgZCI(twTYKVhR, 64616); i++)
			{
				num = (Class15.I9IgXm7u(twTYKVhR, i, 26430) ^ num) * 16777619;
			}
		}
		return num;
	}
}
