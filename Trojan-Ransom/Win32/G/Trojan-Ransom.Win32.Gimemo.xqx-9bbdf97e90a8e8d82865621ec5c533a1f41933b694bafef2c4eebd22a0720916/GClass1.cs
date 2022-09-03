using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

public sealed class GClass1
{
	[DebuggerNonUserCode]
	public GClass1()
	{
	}

	[DllImport("kernel32.dll")]
	private static extern int GetLocaleInfo(uint uint_0, uint uint_1, [Out] StringBuilder stringBuilder_0, int int_0);

	private static string smethod_0(uint uint_0)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		int localeInfo = GetLocaleInfo(1024u, uint_0, stringBuilder, stringBuilder.Capacity);
		if (localeInfo > 0)
		{
			return stringBuilder.ToString().Substring(0, checked(localeInfo - 1));
		}
		return string.Empty;
	}

	public static object smethod_1()
	{
		return smethod_0(4098u);
	}
}
