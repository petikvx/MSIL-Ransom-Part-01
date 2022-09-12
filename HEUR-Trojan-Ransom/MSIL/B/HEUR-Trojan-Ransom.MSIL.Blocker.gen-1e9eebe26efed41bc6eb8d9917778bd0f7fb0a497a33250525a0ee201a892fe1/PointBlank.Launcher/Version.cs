using System;
using System.Reflection;

namespace PointBlank.Launcher;

public class Version
{
	public static string Ver = Version.smethod_3((object)Version.smethod_2(Version.smethod_1(Version.smethod_0())));

	public static string getVersion()
	{
		return Ver;
	}

	static Assembly smethod_0()
	{
		return Assembly.GetExecutingAssembly();
	}

	static AssemblyName smethod_1(Assembly assembly_0)
	{
		return assembly_0.GetName();
	}

	static System.Version smethod_2(AssemblyName assemblyName_0)
	{
		return assemblyName_0.Version;
	}

	static string smethod_3(object object_0)
	{
		return object_0.ToString();
	}
}
