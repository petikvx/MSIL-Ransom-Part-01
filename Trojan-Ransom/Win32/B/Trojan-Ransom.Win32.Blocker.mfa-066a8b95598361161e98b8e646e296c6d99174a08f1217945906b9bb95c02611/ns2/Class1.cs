using System;
using System.IO;
using System.Reflection;
using ns3;

namespace ns2;

internal sealed class Class1
{
	private static Assembly assembly_0;

	internal static void smethod_0()
	{
		AppDomain.CurrentDomain.ResourceResolve += smethod_3;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_1;
	}

	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = smethod_2(executingAssembly);
		if (resolveEventArgs_0.Name.StartsWith(text))
		{
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
			byte[] rawAssembly = Class3.smethod_1(manifestResourceStream);
			return Assembly.Load(rawAssembly);
		}
		return null;
	}

	private static string smethod_2(Assembly assembly_1)
	{
		string text = assembly_1.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text + text + text;
	}

	private static Assembly smethod_3(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if ((object)assembly_0 == null)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string assemblyString = smethod_2(executingAssembly);
			assembly_0 = Assembly.Load(assemblyString);
		}
		if ((object)assembly_0 != null)
		{
			string[] manifestResourceNames = assembly_0.GetManifestResourceNames();
			int num = 0;
			while (true)
			{
				if (num < manifestResourceNames.Length)
				{
					string text = manifestResourceNames[num];
					if (text == resolveEventArgs_0.Name)
					{
						break;
					}
					num++;
					continue;
				}
				return null;
			}
			return assembly_0;
		}
		return assembly_0;
	}
}
