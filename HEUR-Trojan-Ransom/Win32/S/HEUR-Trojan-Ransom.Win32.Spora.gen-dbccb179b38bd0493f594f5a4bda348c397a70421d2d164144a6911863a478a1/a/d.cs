using System;
using System.Reflection;
using hospitally.Properties;

namespace a;

internal sealed class d
{
	internal delegate Assembly f(byte[] byte_0);

	internal static Type r = l.u().GetType(r());

	private static string r()
	{
		return Settings.Default.Setting3;
	}
}
