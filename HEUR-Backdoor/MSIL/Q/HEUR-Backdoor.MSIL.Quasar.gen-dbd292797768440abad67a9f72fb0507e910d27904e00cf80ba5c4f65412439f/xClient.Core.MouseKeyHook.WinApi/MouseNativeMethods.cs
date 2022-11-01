using System.Runtime.InteropServices;

namespace xClient.Core.MouseKeyHook.WinApi;

internal static class MouseNativeMethods
{
	[DllImport("user32.dll")]
	internal static extern int GetDoubleClickTime();
}
