using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

internal static class Class11
{
	internal enum Enum1
	{
		const_0,
		const_1
	}

	private static readonly IntPtr intptr_0 = new IntPtr(-1);

	private static uint uint_0;

	private static uint uint_1;

	internal static void smethod_0(Enum1 enum1_0)
	{
		switch (enum1_0)
		{
		case Enum1.const_1:
			try
			{
				smethod_2(Class2.string_10);
				break;
			}
			catch
			{
				smethod_1();
				break;
			}
		case Enum1.const_0:
			smethod_1();
			break;
		}
	}

	private static void smethod_1()
	{
		if (Class2.string_9 != null)
		{
			Class2.string_10 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), Path.GetFileName(Class2.string_9));
		}
	}

	private static void smethod_2(string string_0)
	{
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.SetValue(Path.GetFileName(string_0), string_0);
	}

	internal static void smethod_3(string string_0)
	{
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)?.DeleteValue(Path.GetFileName(string_0), throwOnMissingValue: false);
	}

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1, int int_2, int int_3, uint uint_2);

	internal static void smethod_4(Form form_0)
	{
		SetWindowPos(((Control)form_0).get_Handle(), intptr_0, 0, 0, 0, 0, 3u);
	}
}
