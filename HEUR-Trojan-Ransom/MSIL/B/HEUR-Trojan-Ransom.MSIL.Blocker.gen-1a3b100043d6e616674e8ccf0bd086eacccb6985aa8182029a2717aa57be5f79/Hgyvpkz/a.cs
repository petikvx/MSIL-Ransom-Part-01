using System;
using System.Runtime.InteropServices;

namespace Hgyvpkz;

[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal static class a
{
	internal static bool a<T>(T[] a)
	{
		if (a == null)
		{
			throw new ArgumentNullException();
		}
		return a.Length != 0;
	}
}
