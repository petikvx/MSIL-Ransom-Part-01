using System;
using System.Threading;
using System.Windows.Forms;

namespace ariec;

internal static class Class0
{
	[STAThread]
	public static bool smethod_0(int int_0)
	{
		if (int_0 != Screen.get_PrimaryScreen().get_Bounds().Width)
		{
			if (Screen.get_PrimaryScreen().get_Bounds().Height > (int_0 ^ 2))
			{
				return true;
			}
			return false;
		}
		return false;
	}

	public static bool smethod_1()
	{
		if (Screen.get_PrimaryScreen().get_Bounds().Width != Screen.get_PrimaryScreen().get_Bounds().Height)
		{
			return true;
		}
		return false;
	}

	private static void Main()
	{
		if (smethod_1())
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
		}
		int num = 0;
		for (num = 0; num < 55; num++)
		{
			if (num != 44 || !smethod_1() || Screen.get_PrimaryScreen().get_Bounds().Width <= 104)
			{
				continue;
			}
			int y = Cursor.get_Position().Y;
			Thread.Sleep(50);
			int x = Cursor.get_Position().X;
			if (y != x)
			{
				if (smethod_1() && smethod_1() && y != x && smethod_0(12))
				{
					Application.Run((Form)(object)new ariapalach());
				}
			}
			else if (smethod_1())
			{
				Application.Run((Form)(object)new ariapalach());
			}
		}
	}
}
