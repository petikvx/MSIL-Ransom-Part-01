using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Class6
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static extern ResourceManager ResourceManager_0 { get; }

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal unsafe static CultureInfo CultureInfo_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0005, IL_000f, IL_0016, IL_001b, IL_0020
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected F8, but got Unknown
			//IL_000c: Expected O, but got I4
			//IL_0011: Invalid comparison between Unknown and I4
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			_003F val = checked(/*Error near IL_0002: Stack underflow*/ - /*Error near IL_0002: Stack underflow*/);
			*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = (double)val;
			/*Error near IL_0004: Unknown opcode: 0xFA*/;
		}
	}

	internal Class6()
	{
		//Discarded unreachable code: IL_000e, IL_0013, IL_001b, IL_001c, IL_0021, IL_0024, IL_0029, IL_0030, IL_0032
		//IL_0002: Expected O, but got I
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		nint num = (nint)((Array)((Array)/*Error near IL_0001: Stack underflow*/).LongLength).LongLength;
		_ = /*Error near IL_0009: Stack underflow*/& (~num * -94);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0);

	static extern Assembly smethod_1(Type type_0);

	static extern ResourceManager smethod_2(string string_0, Assembly assembly_0);
}
