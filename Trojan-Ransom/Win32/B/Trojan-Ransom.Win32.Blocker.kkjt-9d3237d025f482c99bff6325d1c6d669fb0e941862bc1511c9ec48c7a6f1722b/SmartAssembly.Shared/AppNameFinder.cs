using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.License;
using ns0;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct1
	{
		internal byte[] byte_0;
	}

	public static string AppName => AppRegistryKeys.smethod_2(AppNameMinusVersion, AppRegistryKeys.smethod_0(512389390, 4), MajorVersion, 879, 846);

	public static int MajorVersion
	{
		get
		{
			Version version_ = new Version(AppRegistryKeys.smethod_0(512389491, 5));
			return SmartAssembly.License.License.smethod_4(version_, 145, 217);
		}
	}

	public static string AppNameMinusVersion => AppRegistryKeys.smethod_0(512389497, 3);

	private AppNameFinder()
	{
	}

	[SecuritySafeCritical]
	static AppNameFinder()
	{
		AppPathFinder.smethod_3();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Control control_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				Class4.smethod_9(control_0, size_0, 644, 672);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Control control_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 41:
				Class4.smethod_10(control_0, eventHandler_0, 878, 770);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_2(string string_0, object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 120:
				return Class4.smethod_11(string_0, object_0, object_1, 221, 132);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_3(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 98:
				return Class4.Class5.Class6.Class7.smethod_5(stream_0, byte_0, int_0, int_1, 351, 262);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_4(Assembly assembly_0, Assembly assembly_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 14:
				return Class4.smethod_12(assembly_0, assembly_1, 968, 1014);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return Class4.Class5.Class6.Class7.smethod_7(assembly_0, 16, 97);
			}
		}
	}

	[SecuritySafeCritical]
	internal static AppDomain smethod_6(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				return Class4.smethod_8(620, 514);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_7(Assembly assembly_0, Assembly assembly_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				return Class4.smethod_12(assembly_0, assembly_1, 294, 281);
			}
		}
	}
}
