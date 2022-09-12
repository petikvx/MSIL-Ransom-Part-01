using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace ns3;

internal class Class13
{
	private static Assembly assembly_0;

	private static string[] string_0 = new string[0];

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += smethod_1;
		}
		catch
		{
		}
	}

	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if ((object)assembly_0 == null)
		{
			lock (string_0)
			{
				assembly_0 = Assembly.Load("{48291f72-b75c-41e9-8bad-76745ad285bb}, PublicKeyToken=3e56350693f7355e");
				if ((object)assembly_0 != null)
				{
					string_0 = assembly_0.GetManifestResourceNames();
				}
			}
		}
		if (!smethod_2(string_0, resolveEventArgs_0.Name))
		{
			return null;
		}
		if (!smethod_3(Assembly.GetExecutingAssembly()))
		{
			return null;
		}
		return assembly_0;
	}

	private static bool smethod_2(IEnumerable<string> ienumerable_0, string string_1)
	{
		foreach (string item in ienumerable_0)
		{
			if (item == string_1)
			{
				return true;
			}
		}
		return false;
	}

	private unsafe static bool smethod_3(Assembly assembly_1)
	{
		void* ptr = stackalloc byte[5];
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			*(int*)ptr = 2;
			while (true)
			{
				if (*(int*)ptr < frames.Length)
				{
					if ((object)frames[*(int*)ptr].GetMethod()!.Module.Assembly != assembly_1)
					{
						(*(int*)ptr)++;
						continue;
					}
					((byte*)ptr)[4] = 1;
					break;
				}
				((byte*)ptr)[4] = 0;
				break;
			}
		}
		catch
		{
			((byte*)ptr)[4] = 1;
		}
		return ((byte*)ptr)[4] != 0;
	}
}
