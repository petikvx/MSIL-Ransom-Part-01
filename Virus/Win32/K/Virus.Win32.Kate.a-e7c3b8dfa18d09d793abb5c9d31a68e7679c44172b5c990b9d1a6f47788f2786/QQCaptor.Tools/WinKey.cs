using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QQCaptor.Tools;

internal class WinKey
{
	[DllImport("user32.dll")]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);

	[DllImport("user32.dll")]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
}
