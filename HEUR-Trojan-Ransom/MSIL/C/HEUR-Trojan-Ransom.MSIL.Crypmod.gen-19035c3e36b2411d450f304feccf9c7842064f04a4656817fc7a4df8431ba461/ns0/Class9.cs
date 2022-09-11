using System.Runtime.InteropServices;

namespace ns0;

internal sealed class Class9
{
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern bool MessageBeep(int int_0);
}
