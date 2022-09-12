using System.Collections.Generic;

namespace Hoehq;

internal static class Helper
{
	internal static byte[] Access(this byte[] s)
	{
		List<byte> list = new List<byte>();
		list.AddRange(s);
		list.Reverse();
		return list.ToArray();
	}
}
