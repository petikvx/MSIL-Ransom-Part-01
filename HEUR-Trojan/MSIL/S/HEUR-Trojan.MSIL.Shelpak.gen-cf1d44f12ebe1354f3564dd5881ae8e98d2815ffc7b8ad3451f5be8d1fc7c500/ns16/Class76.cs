using System;
using System.Threading;

namespace ns16;

internal sealed class Class76
{
	private static readonly int int_0 = 0;

	private static readonly int int_1 = 10;

	public static void smethod_0()
	{
		Thread.Sleep(new Random().Next(int_0 * 1000, int_1 * 1000));
	}
}
