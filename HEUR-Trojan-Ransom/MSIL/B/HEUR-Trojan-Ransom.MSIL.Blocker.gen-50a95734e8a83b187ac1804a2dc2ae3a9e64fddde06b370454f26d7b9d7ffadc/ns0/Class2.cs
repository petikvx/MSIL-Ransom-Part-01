using System;
using System.Reflection;
using System.Threading;

namespace ns0;

internal class Class2
{
	static int smethod_0(string string_0)
	{
		Assembly[] assemblies = Thread.GetDomain().GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			if (!(assembly.FullName == string_0))
			{
				continue;
			}
			Type[] exportedTypes = assembly.GetExportedTypes();
			foreach (Type type in exportedTypes)
			{
				if (!(type.FullName == "Iuagagsbgjolx.Cnwsspglnxnobme"))
				{
					continue;
				}
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Aaeqwckdowxdmdpal")
					{
						Environment.SpecialFolder specialFolder = (Environment.SpecialFolder)methodInfo.Invoke(null, null);
						return Convert.ToInt32(specialFolder);
					}
				}
			}
		}
		return 1;
	}
}
