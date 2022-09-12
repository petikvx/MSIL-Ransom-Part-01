using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns38;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static object nullCacheLock;

	private static Dictionary<string, bool> nullCache;

	private static Dictionary<string, string> assemblyNames;

	private static Dictionary<string, string> symbolNames;

	private static int isAttached;

	private static AssemblyLoader assemblyLoader_0;

	private static string CultureToString(CultureInfo culture)
	{
		return null;
	}

	private static Assembly ReadExistingAssembly(AssemblyName name)
	{
		return null;
	}

	private static void CopyTo(Stream source, Stream destination)
	{
	}

	private static Stream LoadStream(string fullName)
	{
		return null;
	}

	private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
	{
		return null;
	}

	private static byte[] ReadStream(Stream stream)
	{
		return null;
	}

	private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
	{
		return null;
	}

	public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
	{
		return null;
	}

	static AssemblyLoader()
	{
		Class21.smethod_22();
		Class21.smethod_13();
		smethod_24();
		smethod_25();
		nullCacheLock = new object();
		nullCache = new Dictionary<string, bool>();
		assemblyNames = new Dictionary<string, string>();
		symbolNames = new Dictionary<string, string>();
		assemblyNames.Add((string)smethod_13(5604756), Class21.smethod_16(5604798));
		assemblyNames.Add((string)smethod_13(5604886), Class21.smethod_16(5604904));
		assemblyNames.Add((string)smethod_13(5604968), (string)smethod_13(5605006));
		assemblyNames.Add((string)smethod_13(5605090), (string)smethod_13(5605116));
		assemblyNames.Add((string)smethod_13(5605188), (string)smethod_13(5605206));
		assemblyNames.Add((string)smethod_13(5605270), (string)smethod_13(5605286));
		assemblyNames.Add(Class21.smethod_16(5605348), (string)smethod_13(5605432));
		assemblyNames.Add((string)smethod_13(5605562), (string)smethod_13(5605690));
		assemblyNames.Add((string)smethod_13(5605864), Class21.smethod_16(5605936));
		assemblyNames.Add((string)smethod_13(5606054), Class21.smethod_16(5606088));
		assemblyNames.Add((string)smethod_13(5606168), (string)smethod_13(5606206));
		assemblyNames.Add((string)smethod_13(5606290), (string)smethod_13(5606314));
		assemblyNames.Add(Class21.smethod_16(5606384), Class21.smethod_16(5606412));
		assemblyNames.Add((string)smethod_13(5606486), (string)smethod_13(5606524));
		symbolNames.Add((string)smethod_13(5606486), Class21.smethod_16(5606608));
		assemblyNames.Add(Class21.smethod_16(5606692), (string)smethod_13(5606710));
		assemblyNames.Add((string)smethod_13(5606774), Class21.smethod_16(5606802));
		symbolNames.Add((string)smethod_13(5606774), (string)smethod_13(5606876));
		assemblyNames.Add((string)smethod_13(5606950), (string)smethod_13(5606992));
		symbolNames.Add((string)smethod_13(5606950), Class21.smethod_16(5607080));
		symbolNames.Add(Class21.smethod_16(5606692), (string)smethod_13(5607168));
		assemblyNames.Add((string)smethod_13(5607232), (string)smethod_13(5607248));
		assemblyNames.Add((string)smethod_13(5607310), (string)smethod_13(5607380));
		assemblyNames.Add((string)smethod_13(5607496), (string)smethod_13(5607520));
	}

	public static void Attach()
	{
	}

	internal static object smethod_0(object object_0)
	{
		return null;
	}

	internal static bool smethod_1()
	{
		return true;
	}

	internal static AssemblyLoader smethod_2()
	{
		return null;
	}

	internal static object smethod_3()
	{
		return null;
	}

	internal static object smethod_4(object object_0)
	{
		return null;
	}

	internal static object smethod_5(object object_0)
	{
		return null;
	}

	internal static object smethod_6(object object_0)
	{
		return null;
	}

	internal static bool smethod_7(object object_0, object object_1, StringComparison stringComparison_0)
	{
		return true;
	}

	internal static object smethod_8(object object_0)
	{
		return null;
	}

	internal static object smethod_9(object object_0)
	{
		return null;
	}

	internal static void smethod_10(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static int smethod_11(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static object smethod_12()
	{
		return null;
	}

	internal static object smethod_13(int int_0)
	{
		return null;
	}

	internal static bool smethod_14(object object_0, object object_1)
	{
		return true;
	}

	internal static object smethod_15(object object_0, object object_1)
	{
		return null;
	}

	internal static void smethod_16(object object_0, object object_1)
	{
	}

	internal static void smethod_17(object object_0)
	{
	}

	internal static object smethod_18(object object_0)
	{
		return null;
	}

	internal static void smethod_19(object object_0)
	{
	}

	internal static bool smethod_20(object object_0, object object_1)
	{
		return true;
	}

	internal static bool smethod_21(object object_0, object object_1)
	{
		return true;
	}

	internal static AssemblyNameFlags smethod_22(object object_0)
	{
		return (AssemblyNameFlags)(object)null;
	}

	internal static object smethod_23(object object_0)
	{
		return null;
	}

	internal static void smethod_24()
	{
	}

	internal static void smethod_25()
	{
	}

	internal static void smethod_26(object object_0, object object_1)
	{
	}
}
