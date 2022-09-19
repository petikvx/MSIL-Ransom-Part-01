using System.Runtime.InteropServices;
using ns0;

namespace idk;

internal class Fork
{
	[DllImport("libc.so.6")]
	public static extern long fork();

	private static extern void F();

	public extern Fork();

	static long smethod_0()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return Delegate17.delegate17_1();
	}
}
