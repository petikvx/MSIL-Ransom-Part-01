using System.Collections.Generic;
using System.Linq;

namespace Impers0nati0n;

public static class Nonmeas3rable
{
	public static string Twee1e(IReadOnlyList<char> Organ4c4sm)
	{
		return string.Concat(Organ4c4sm).Replace("™\u009d.Y3;", "");
	}

	public static IReadOnlyList<byte> Out3ri3ing(IEnumerable<byte> Italicizati5ns, IReadOnlyList<char> ireadOnlyList_0)
	{
		return Italicizati5ns.Select((byte x, int i) => (byte)(ireadOnlyList_0[i % ireadOnlyList_0.Count] ^ x)).ToArray();
	}
}
