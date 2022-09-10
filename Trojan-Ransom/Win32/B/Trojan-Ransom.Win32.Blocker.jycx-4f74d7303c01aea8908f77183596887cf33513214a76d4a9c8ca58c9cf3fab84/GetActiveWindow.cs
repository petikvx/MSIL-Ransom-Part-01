using System;
using System.Runtime.InteropServices;
using System.Text;

internal class GetActiveWindow
{
	private string makel;

	[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int cch);

	public string GetCaption()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		IntPtr foregroundWindow = GetForegroundWindow();
		GetWindowText(foregroundWindow, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}
}
