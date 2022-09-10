using System;
using System.IO;
using System.Reflection;

namespace Microsoft.Tools.RegAsm;

internal class AssemblyResolver
{
	private string[] m_lstPaths;

	internal AssemblyResolver(string asmpaths)
	{
		if (asmpaths != null)
		{
			m_lstPaths = asmpaths.Split(new char[1] { ';' });
		}
		else
		{
			m_lstPaths = null;
		}
		AppDomain.CurrentDomain.ReflectionOnlyAssemblyResolve += ResolveAssembly;
	}

	private Assembly ResolveAssembly(object sender, ResolveEventArgs args)
	{
		string name = args.Name;
		Assembly assembly = null;
		if (m_lstPaths == null)
		{
			string assemblyString = AppDomain.CurrentDomain.ApplyPolicy(name);
			assembly = Assembly.ReflectionOnlyLoad(assemblyString);
		}
		else
		{
			AssemblyName assemblyName = new AssemblyName(name);
			name = assemblyName.Name;
			string text = name + ".dll";
			string[] lstPaths = m_lstPaths;
			foreach (string text2 in lstPaths)
			{
				string text3 = text2 + "\\" + text;
				if (File.Exists(text3))
				{
					assembly = Assembly.ReflectionOnlyLoadFrom(text3);
					break;
				}
			}
			if ((object)assembly == null)
			{
				string text4 = name + ".exe";
				string[] lstPaths2 = m_lstPaths;
				foreach (string text5 in lstPaths2)
				{
					string text6 = text5 + "\\" + text4;
					if (File.Exists(text6))
					{
						assembly = Assembly.ReflectionOnlyLoadFrom(text6);
						break;
					}
				}
			}
		}
		if ((object)assembly == null)
		{
			throw new FileNotFoundException(Resource.FormatString("Err_RefAsmNotInAsmPath", name));
		}
		if (RegCode.s_Options.m_bVerboseMode)
		{
			Output.WriteInfo(Resource.FormatString("Msg_RefAsmResolvedToAsm", name, assembly.FullName, assembly.CodeBase));
		}
		return assembly;
	}
}
