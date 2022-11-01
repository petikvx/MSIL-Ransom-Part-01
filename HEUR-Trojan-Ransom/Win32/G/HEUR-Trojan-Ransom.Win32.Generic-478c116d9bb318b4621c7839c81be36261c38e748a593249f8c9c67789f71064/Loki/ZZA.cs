using System;
using System.Threading;

namespace Loki;

internal class ZZA
{
	private const string ZZH = "Loki";

	private const string ZZI = "logs.txt";

	private static IntPtr ZZJ;

	private static Mutex ZZK;

	private static bool ZZL;

	static extern ZZA();

	public static extern void ZZB(bool bool_0);

	public static extern void ZZC();

	public unsafe static void ZZD(Exception exception_0)
	{
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		_ = (object)exception_0 & (object)exception_0;
		/*Error: Unexpected end of block*/;
	}

	public static extern void ZZE(string string_0);

	public static extern void ZZF(string string_0);

	public static extern void ZZG();

	public extern ZZA();
}
