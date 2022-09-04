using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Lexplorer;

internal static class Class9
{
	private static Form dummy = new Form();

	public static void TurnOn()
	{
		Class25.SendMessage((int)((Control)dummy).get_Handle(), 274, 61808, -1);
	}

	public static void TurnOff()
	{
		Class25.SendMessage((int)((Control)dummy).get_Handle(), 274, 61808, 2);
	}

	public static void SetStateEnabled(bool enabled)
	{
		if (enabled)
		{
			TurnOn();
		}
		else
		{
			TurnOff();
		}
	}

	public static Size GetCurrentResolution()
	{
		Size result = new Size(0, 0);
		DEVMODE lpDevMode = default(DEVMODE);
		lpDevMode.dmSize = (ushort)Marshal.SizeOf((object)lpDevMode);
		if (Class25.EnumDisplaySettings(null, -1, ref lpDevMode))
		{
			return new Size((int)lpDevMode.dmPelsWidth, (int)lpDevMode.dmPelsHeight);
		}
		return result;
	}

	public static bool SetResolution(int width, int height)
	{
		DEVMODE lpDevMode = default(DEVMODE);
		lpDevMode.dmSize = (ushort)Marshal.SizeOf((object)lpDevMode);
		Class25.EnumDisplaySettings(null, -1, ref lpDevMode);
		DEVMODE lpDevMode2 = lpDevMode;
		lpDevMode2.dmPelsWidth = (uint)width;
		lpDevMode2.dmPelsHeight = (uint)height;
		lpDevMode2.dmBitsPerPel = 32u;
		if (Class25.ChangeDisplaySettings(ref lpDevMode2, 0u) == 0)
		{
			return true;
		}
		return false;
	}
}
