using System;
using System.Diagnostics;
using System.Reflection;

namespace ns4;

internal sealed class Class13
{
	private static Assembly assembly_0 = null;

	private static string[] string_0 = new string[0];

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += smethod_1;
		}
		catch (Exception)
		{
		}
	}

	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if ((object)assembly_0 == null)
		{
			lock (string_0)
			{
				assembly_0 = Assembly.Load("{925551dd-6f56-4cf2-b172-4d2cb6b8fa2c}, PublicKeyToken=3e56350693f7355e");
				if ((object)assembly_0 != null)
				{
					string_0 = assembly_0.GetManifestResourceNames();
				}
			}
		}
		string name = resolveEventArgs_0.Name;
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		if (!smethod_2())
		{
			return null;
		}
		return assembly_0;
	}

	private unsafe static bool smethod_2()
	{
		void* ptr = stackalloc byte[6];
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			*(int*)ptr = 2;
			while (true)
			{
				if (*(int*)ptr < frames.Length)
				{
					StackFrame stackFrame = frames[*(int*)ptr];
					if ((object)stackFrame.GetMethod()!.Module.Assembly != Assembly.GetExecutingAssembly())
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
		((byte*)ptr)[5] = ((byte*)ptr)[4];
		return ((byte*)ptr)[5] != 0;
	}
}
