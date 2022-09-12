using System;

namespace Hifjc;

internal class Program
{
	[STAThread]
	private static int Main()
	{
		Internet.Config();
		Internet.App();
		Internet.Info();
		return 0;
	}
}
