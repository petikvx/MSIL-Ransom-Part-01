using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Costura;

[CompilerGenerated]
internal static class AssemblyLoader
{
	private static object nullCacheLock;

	private static Dictionary<string, bool> nullCache;

	private static Dictionary<string, string> assemblyNames;

	private static Dictionary<string, string> symbolNames;

	private static int isAttached;

	private static extern string CultureToString(CultureInfo culture);

	private static extern Assembly ReadExistingAssembly(AssemblyName name);

	private static extern void CopyTo(Stream source, Stream destination);

	private static extern Stream LoadStream(string fullName);

	private static extern Stream LoadStream(Dictionary<string, string> resourceNames, string name);

	private static byte[] ReadStream(Stream stream)
	{
		while (true)
		{
			if (/*Error near IL_0007: Stack underflow*/ == /*Error near IL_0007: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	private static extern Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName);

	public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Invalid metadata token*/;
	}

	unsafe static AssemblyLoader()
	{
		_ = *(uint*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	public static void Attach()
	{
		//Discarded unreachable code: IL_000e
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		/*OpCode not supported: DebugBreak*/;
		checked
		{
			_ = /*Error near IL_0009: Stack underflow*/- 9.863003E-32f;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}
}
