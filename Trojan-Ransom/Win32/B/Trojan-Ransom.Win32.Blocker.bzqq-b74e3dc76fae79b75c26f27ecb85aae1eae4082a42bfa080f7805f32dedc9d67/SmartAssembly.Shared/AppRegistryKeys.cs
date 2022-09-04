using System;
using System.Globalization;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.Shared;

public sealed class AppRegistryKeys
{
	public static string SubkeyApplication
	{
		get
		{
			try
			{
				return Form0.smethod_1("Software\\Red Gate\\", AppNameFinder.AppName, 941, 927);
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	public static string WowSubkeyApplication
	{
		get
		{
			try
			{
				return Form0.smethod_1("Software\\Wow6432Node\\Red Gate\\", AppNameFinder.AppName, 314, 264);
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	public static object GetRegistryEntry(string valueName, object defaultValue)
	{
		RegistryKey registryKey = default(RegistryKey);
		int num = default(int);
		object obj = default(object);
		object obj2 = default(object);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(Registry.LocalMachine, SubkeyApplication, 978, 959);
			try
			{
				num = 4;
				if (registryKey == null)
				{
					obj = defaultValue;
					return obj;
				}
				obj2 = DoNotPruneTypeAttribute.smethod_0(registryKey, valueName, defaultValue, 341, 365);
			}
			finally
			{
				num2 = 0;
				((IDisposable)registryKey)?.Dispose();
			}
			num3 = 4;
			return obj2;
		}
		catch (Exception exception)
		{
			int num4 = default(int);
			StackFrameHelper.CreateException9(exception, obj2, registryKey, obj, num4, num, num2, num3, valueName, defaultValue);
			throw;
		}
	}

	private AppRegistryKeys()
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

	static AppRegistryKeys()
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

	internal static byte[] smethod_0(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 40:
					return Convert.FromBase64String(string_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Thread thread_0, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 47:
					thread_0.Start(object_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, thread_0, object_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Thread thread_0, CultureInfo cultureInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 1:
					thread_0.CurrentUICulture = cultureInfo_0;
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, thread_0, cultureInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_3(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 116:
					return fieldInfo_0.IsStatic;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, fieldInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static string[] smethod_4(Assembly assembly_0, int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					return assembly_0.GetManifestResourceNames();
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
