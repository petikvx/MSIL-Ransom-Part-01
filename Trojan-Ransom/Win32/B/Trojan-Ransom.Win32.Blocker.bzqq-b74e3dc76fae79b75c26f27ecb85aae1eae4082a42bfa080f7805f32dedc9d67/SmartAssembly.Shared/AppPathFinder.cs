using System;
using System.Globalization;
using System.Reflection;
using System.Security.Policy;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.Shared;

public class AppPathFinder
{
	public static string ReadInstalledSaPath()
	{
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		string text = default(string);
		string text2 = default(string);
		int num2 = default(int);
		try
		{
			try
			{
				num = 6;
				registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(Registry.LocalMachine, AppRegistryKeys.SubkeyApplication, 963, 942);
				if (registryKey == null)
				{
					num = 2;
					registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(Registry.LocalMachine, AppRegistryKeys.WowSubkeyApplication, 987, 950);
					num = 3;
				}
				else
				{
					num = 3;
				}
				if (registryKey == null)
				{
					num = 1;
					text = null;
				}
				else
				{
					num = 7;
					text2 = (string)DoNotPruneTypeAttribute.smethod_0(registryKey, "Path", null, 723, 747);
					num = 8;
					SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_0(registryKey, 680, 756);
					text = text2;
				}
			}
			catch
			{
				text = null;
			}
			num2 = 4;
			return text;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, registryKey, text2, text, num, num2);
			throw;
		}
	}

	public AppPathFinder()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static AppPathFinder()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_0(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_4 ^ int_3)
				{
				case 26:
					Array.Copy(array_0, int_0, array_1, int_1, int_2);
					return;
				case 27:
					Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException9(exception, num, num2, array_0, int_0, array_1, int_1, int_2, int_3, int_4);
			throw;
		}
	}

	internal static int smethod_1(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 55:
					return string_0.Length;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_2(CultureInfo cultureInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return cultureInfo_0.Name;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, cultureInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_3(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 43:
					return IntPtr.Size;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_4(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					return intptr_0 != intptr_1;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, intptr_0, intptr_1, int_0, int_1);
			throw;
		}
	}

	internal static Evidence smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return assembly_0.get_Evidence();
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, assembly_0, int_0, int_1);
			throw;
		}
	}
}
