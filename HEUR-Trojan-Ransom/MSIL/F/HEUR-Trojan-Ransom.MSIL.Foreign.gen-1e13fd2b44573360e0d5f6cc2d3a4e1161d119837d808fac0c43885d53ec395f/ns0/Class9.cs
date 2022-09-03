using System.Runtime.InteropServices;
using System.Text;

namespace ns0;

internal class Class9
{
	private const uint uint_0 = 1024u;

	private const uint uint_1 = 4098u;

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_2, uint uint_3, [Out] StringBuilder stringBuilder_0, int int_0);

	private static string smethod_0(uint uint_2)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, uint_2, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, localeInfo - 1);
		}
		return string.Empty;
	}

	public static string smethod_1()
	{
		return smethod_0(4098u);
	}
}
