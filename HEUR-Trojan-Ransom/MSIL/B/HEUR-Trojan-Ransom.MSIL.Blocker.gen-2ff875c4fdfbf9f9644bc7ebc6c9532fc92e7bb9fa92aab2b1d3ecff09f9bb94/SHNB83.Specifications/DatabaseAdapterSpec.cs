using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using SHNB83.Listeners;

namespace SHNB83.Specifications;

internal static class DatabaseAdapterSpec
{
	private static DatabaseAdapterSpec PatchUtils;

	[SpecialName]
	[CompilerGenerated]
	internal static string RateExporter()
	{
		return _Tokenizer;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void InitExporter(string param)
	{
		_Tokenizer = param;
	}

	internal static void QueryExporter()
	{
		List<Exception> list = new List<Exception>();
		try
		{
			InitExporter(PopExporter());
		}
		catch (Exception item)
		{
			list.Add(item);
		}
		finally
		{
			foreach (Exception item2 in list)
			{
				MapUtils(item2.StackTrace);
			}
		}
	}

	private static string PopExporter()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		object obj = (from ManagementObject x in (IEnumerable)new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get()
			select ((ManagementBaseObject)x).GetPropertyValue("Caption")).FirstOrDefault();
		object obj2;
		if (obj == null)
		{
			if (CountUtils() != null)
			{
				switch (0)
				{
				}
			}
			obj2 = "Unknown";
		}
		else
		{
			obj2 = obj.ToString();
		}
		return ((string)obj2).Trim() + " " + (Environment.Is64BitOperatingSystem ? "64-bit" : "32-bit");
	}

	internal static void MapUtils(object object_0)
	{
		Tag.FlushExporter((string)object_0);
	}

	internal static bool CloneUtils()
	{
		return PatchUtils == null;
	}

	internal static DatabaseAdapterSpec CountUtils()
	{
		return PatchUtils;
	}
}
