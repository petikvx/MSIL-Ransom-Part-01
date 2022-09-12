using System;
using System.Collections.Generic;
using System.Reflection;

namespace AjScript;

public class TypeUtilities
{
	private static bool referencedAssembliesLoaded;

	public static Type GetType(IContext context, string name)
	{
		object value = context.GetValue(name);
		if (value != null && value is Type)
		{
			return (Type)value;
		}
		return GetType(name);
	}

	public static Type AsType(string name)
	{
		Type type = Type.GetType(name);
		if (type != null)
		{
			return type;
		}
		type = GetTypeFromLoadedAssemblies(name);
		if (type != null)
		{
			return type;
		}
		type = GetTypeFromPartialNamedAssembly(name);
		if (type != null)
		{
			return type;
		}
		LoadReferencedAssemblies();
		type = GetTypeFromLoadedAssemblies(name);
		if (type != null)
		{
			return type;
		}
		return null;
	}

	public static Type GetType(string name)
	{
		Type type = AsType(name);
		if (!(type != null))
		{
			throw new InvalidOperationException($"Unknown type '{name}'");
		}
		return type;
	}

	public static bool IsNamespace(string name)
	{
		return GetNamespaces().Contains(name);
	}

	public static object InvokeTypeMember(Type type, string name, object[] parameters)
	{
		return type.InvokeMember(name, BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy | BindingFlags.InvokeMethod | BindingFlags.GetField | BindingFlags.GetProperty, null, null, parameters);
	}

	private static ICollection<string> GetNamespaces()
	{
		List<string> list = new List<string>();
		LoadReferencedAssemblies();
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		for (int i = 0; i < assemblies.Length; i++)
		{
			Type[] types = assemblies[i].GetTypes();
			foreach (Type type in types)
			{
				if (!list.Contains(type.Namespace))
				{
					list.Add(type.Namespace);
				}
			}
		}
		return list;
	}

	private static Type GetTypeFromPartialNamedAssembly(string name)
	{
		int num = name.LastIndexOf(".");
		if (num < 0)
		{
			return null;
		}
		string partialName = name.Substring(0, num);
		try
		{
			return Assembly.LoadWithPartialName(partialName)!.GetType(name);
		}
		catch
		{
			return null;
		}
	}

	private static Type GetTypeFromLoadedAssemblies(string name)
	{
		Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
		int num = 0;
		Type type;
		while (true)
		{
			if (num < assemblies.Length)
			{
				type = assemblies[num].GetType(name);
				if (type != null)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return type;
	}

	private static void LoadReferencedAssemblies()
	{
		if (!referencedAssembliesLoaded)
		{
			List<string> list = new List<string>();
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				list.Add(assembly.GetName().Name);
			}
			assemblies = AppDomain.CurrentDomain.GetAssemblies();
			for (int i = 0; i < assemblies.Length; i++)
			{
				LoadReferencedAssemblies(assemblies[i], list);
			}
			referencedAssembliesLoaded = true;
		}
	}

	private static void LoadReferencedAssemblies(Assembly assembly, List<string> loaded)
	{
		AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
		foreach (AssemblyName assemblyName in referencedAssemblies)
		{
			if (!loaded.Contains(assemblyName.Name))
			{
				loaded.Add(assemblyName.Name);
				LoadReferencedAssemblies(Assembly.Load(assemblyName), loaded);
			}
		}
	}
}
