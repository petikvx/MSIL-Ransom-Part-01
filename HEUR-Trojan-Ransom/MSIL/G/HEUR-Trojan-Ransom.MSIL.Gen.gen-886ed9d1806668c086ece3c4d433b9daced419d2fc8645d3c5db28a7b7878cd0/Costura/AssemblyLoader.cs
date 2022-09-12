using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns49;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static object nullCacheLock;

	private static Dictionary<string, bool> nullCache;

	private static Dictionary<string, string> assemblyNames;

	private static Dictionary<string, string> symbolNames;

	private static int isAttached;

	internal static AssemblyLoader assemblyLoader_0;

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
		Class25.smethod_22();
		smethod_24();
		smethod_25();
		smethod_26();
		nullCacheLock = new object();
		nullCache = new Dictionary<string, bool>();
		assemblyNames = new Dictionary<string, string>();
		symbolNames = new Dictionary<string, string>();
		assemblyNames.Add((string)smethod_12(5689530), (string)smethod_12(5689572));
		assemblyNames.Add((string)smethod_12(5689660), (string)smethod_12(5689678));
		assemblyNames.Add((string)smethod_12(5689742), (string)smethod_12(5689780));
		assemblyNames.Add((string)smethod_12(5689864), (string)smethod_12(5689890));
		assemblyNames.Add((string)smethod_12(5689962), Class25.smethod_16(5689980));
		assemblyNames.Add((string)smethod_12(5690044), Class25.smethod_16(5690060));
		assemblyNames.Add((string)smethod_12(5690122), (string)smethod_12(5690206));
		assemblyNames.Add(Class25.smethod_16(5690336), Class25.smethod_16(5690464));
		assemblyNames.Add(Class25.smethod_16(5690638), (string)smethod_12(5690710));
		assemblyNames.Add((string)smethod_12(5690828), Class25.smethod_16(5690862));
		assemblyNames.Add((string)smethod_12(5690942), Class25.smethod_16(5690980));
		assemblyNames.Add(Class25.smethod_16(5691064), (string)smethod_12(5691088));
		assemblyNames.Add((string)smethod_12(5691158), (string)smethod_12(5691186));
		assemblyNames.Add((string)smethod_12(5691260), (string)smethod_12(5691298));
		symbolNames.Add(Class25.smethod_16(5691260), (string)smethod_12(5691382));
		assemblyNames.Add((string)smethod_12(5691466), (string)smethod_12(5691484));
		assemblyNames.Add((string)smethod_12(5691548), Class25.smethod_16(5691576));
		symbolNames.Add(Class25.smethod_16(5691548), Class25.smethod_16(5691650));
		assemblyNames.Add((string)smethod_12(5691724), (string)smethod_12(5691766));
		symbolNames.Add((string)smethod_12(5691724), (string)smethod_12(5691854));
		symbolNames.Add((string)smethod_12(5691466), (string)smethod_12(5691942));
		assemblyNames.Add((string)smethod_12(5692006), (string)smethod_12(5692022));
		assemblyNames.Add((string)smethod_12(5692084), Class25.smethod_16(5692154));
		assemblyNames.Add((string)smethod_12(5692270), (string)smethod_12(5692294));
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

	internal static bool smethod_6(object object_0, object object_1, StringComparison stringComparison_0)
	{
		return true;
	}

	internal static object smethod_7(object object_0)
	{
		return null;
	}

	internal static object smethod_8(object object_0)
	{
		return null;
	}

	internal static void smethod_9(object object_0, object object_1, int int_0, int int_1)
	{
	}

	internal static int smethod_10(object object_0, object object_1, int int_0, int int_1)
	{
		return 0;
	}

	internal static object smethod_11()
	{
		return null;
	}

	internal static object smethod_12(int int_0)
	{
		return null;
	}

	internal static bool smethod_13(object object_0, object object_1)
	{
		return true;
	}

	internal static void smethod_14(object object_0, object object_1)
	{
	}

	internal static void smethod_15(object object_0)
	{
	}

	internal static object smethod_16(object object_0, object object_1)
	{
		return null;
	}

	internal static long smethod_17(object object_0)
	{
		return 0L;
	}

	internal static object smethod_18(object object_0)
	{
		return null;
	}

	internal static void smethod_19(object object_0)
	{
	}

	internal static object smethod_20(object object_0)
	{
		return null;
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

	internal static void smethod_26()
	{
	}

	internal static void smethod_27(object object_0, object object_1)
	{
	}
}
