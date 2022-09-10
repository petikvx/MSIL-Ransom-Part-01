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
	private static readonly Dictionary<string, bool> nullCache;

	private static readonly Dictionary<string, string> assemblyNames;

	private static readonly Dictionary<string, string> symbolNames;

	private static ResolveEventHandler CS_0024_003C_003E9__CachedAnonymousMethodDelegate1;

	private static extern string CultureToString(CultureInfo culture);

	private static extern Assembly ReadExistingAssembly(AssemblyName name);

	private unsafe static void CopyTo(Stream source, Stream destination)
	{
		//Discarded unreachable code: IL_0012
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got I4
		do
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (long)/*Error near IL_0003: Stack underflow*/;
		}
		while (/*Error near IL_0008: Stack underflow*/ <= /*Error near IL_0008: Stack underflow*/);
		sbyte num = *(sbyte*)checked((int)/*Error near IL_0009: Stack underflow*/);
		checked
		{
			_ = (short)(/*Error near IL_000b: Stack underflow*/ ^ num);
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	private unsafe static Stream LoadStream(string fullname)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
		IntPtr intPtr = ((IntPtr[])/*Error near IL_0002: Stack underflow*/)[val];
		((short[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = (short)(nint)intPtr;
		_ = *(sbyte*)(nint)/*Error near IL_0004: Stack underflow*/;
		/*Error near IL_0004: ldloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	private static extern Stream LoadStream(Dictionary<string, string> resourceNames, string name);

	private unsafe static byte[] ReadStream(Stream stream)
	{
		//Discarded unreachable code: IL_0002, IL_0005
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected F8, but got I8
		//IL_001d: Expected F8, but got I8
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xF9*/;
	}

	private static extern Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName);

	public static extern Assembly ResolveAssembly(string assemblyName);

	private static extern Assembly _003CAttach_003Eb__0(object s, ResolveEventArgs e);

	public static void Attach()
	{
		//Discarded unreachable code: IL_0006, IL_000f, IL_0014, IL_001f, IL_0024, IL_002d, IL_0033
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Incompatible stack heights: 0 vs 2
		//IL_002e: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}
}
