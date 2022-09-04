using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Policy;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using ns0;

namespace SmartAssembly.Shared;

public class AppPathFinder
{
	private static bool bool_0;

	public static string ReadInstalledSaPath()
	{
		try
		{
			RegistryKey registryKey = smethod_0(Registry.LocalMachine, AppRegistryKeys.SubkeyApplication, 850, 834);
			if (registryKey == null)
			{
				registryKey = smethod_0(Registry.LocalMachine, AppRegistryKeys.WowSubkeyApplication, 918, 902);
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)SmartAssembly.License.License.smethod_2(registryKey, AppRegistryKeys.smethod_0(512389382, 7), null, 551, 611);
			SmartAssembly.License.License.smethod_3(registryKey, 931, 946);
			return result;
		}
		catch
		{
			return null;
		}
	}

	[SecuritySafeCritical]
	static AppPathFinder()
	{
		smethod_3();
	}

	[SecuritySafeCritical]
	internal static RegistryKey smethod_0(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return Class4.Class5.Class6.smethod_2(registryKey_0, string_0, 570, 610);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Control control_0, Point point_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 31:
				Class0.smethod_10(control_0, point_0, 1009, 902);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 125:
				return Class4.Class5.Class6.smethod_3(string_0, 72, 123);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3()
	{
		if (bool_0)
		{
			return;
		}
		Type object_;
		Class4.Class5.Class6.smethod_4(object_ = Class0.smethod_11(typeof(AppPathFinder).TypeHandle, 834, 800), 503, 476);
		try
		{
			if (!bool_0)
			{
				bool_0 = true;
				Class4.smethod_5(Class4.smethod_8(436, 474), DoNotDistributeAttribute.smethod_0, 62, 66);
			}
		}
		finally
		{
			Class4.Class5.Class6.smethod_4(object_, 439, 411);
		}
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_4(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return Class4.Class5.Class6.Class7.smethod_6(memoryStream_0, 159, 155);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Evidence smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 10:
				return Class4.Class5.Class6.smethod_5(assembly_0, 56, 47);
			}
		}
	}
}
