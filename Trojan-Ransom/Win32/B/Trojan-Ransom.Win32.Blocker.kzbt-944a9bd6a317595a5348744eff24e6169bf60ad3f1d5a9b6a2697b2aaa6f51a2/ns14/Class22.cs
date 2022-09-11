using System;
using System.Diagnostics;
using System.Reflection;

namespace ns14;

internal class Class22
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
				assembly_0 = Assembly.Load("{84aebe9b-e64f-4ceb-997b-6ce24417c063}, PublicKeyToken=3e56350693f7355e");
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

	private static bool smethod_2()
	{
		try
		{
			StackFrame[] frames = new StackTrace().GetFrames();
			int num = 2;
			while (true)
			{
				if (num < frames.Length)
				{
					StackFrame stackFrame = frames[num];
					if ((object)stackFrame.GetMethod()!.Module.Assembly == Assembly.GetExecutingAssembly())
					{
						break;
					}
					num++;
					continue;
				}
				return false;
			}
			return true;
		}
		catch
		{
			return true;
		}
	}
}
