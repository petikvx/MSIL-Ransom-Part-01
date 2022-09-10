using System;
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

	private const uint uint_0 = 1u;

	private const uint uint_1 = 2u;

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
			Class2.string_10 = Delegate98.smethod_0(Delegate200.smethod_0(Environment.SpecialFolder.Startup), Delegate233.smethod_0(Class2.string_9));
		}
	}

	private static void smethod_2(string string_0)
	{
		RegistryKey registryKey = Delegate91.smethod_0(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", bool_0: true);
		if (registryKey != null)
		{
			Delegate7.smethod_0(registryKey, Delegate233.smethod_0(string_0), string_0);
		}
	}

	internal static void smethod_3(string string_0)
	{
		RegistryKey registryKey = Delegate91.smethod_0(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", bool_0: true);
		if (registryKey != null)
		{
			Delegate158.smethod_0(registryKey, Delegate233.smethod_0(string_0), bool_0: false);
		}
	}

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(IntPtr intptr_1, IntPtr intptr_2, int int_0, int int_1, int int_2, int int_3, uint uint_2);

	internal static void smethod_4(Form form_0)
	{
		SetWindowPos(Delegate102.smethod_0(form_0), intptr_0, 0, 0, 0, 0, 3u);
	}
}
