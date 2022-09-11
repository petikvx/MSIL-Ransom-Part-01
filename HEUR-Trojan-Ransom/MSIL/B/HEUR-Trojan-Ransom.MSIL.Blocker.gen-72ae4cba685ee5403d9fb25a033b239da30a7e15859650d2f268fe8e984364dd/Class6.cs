using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Class6
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static extern ResourceManager ResourceManager_0 { get; }

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal unsafe static CultureInfo CultureInfo_0
	{
		get
		{
			//Discarded unreachable code: IL_0015
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_000f: Expected I8, but got I
			nint num;
			checked
			{
				do
				{
					_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
				}
				while ((uint)unchecked((byte)/*Error near IL_0004: Stack underflow*/) == 0);
				num = (nint)/*Error near IL_000d: Stack underflow*/;
			}
			*(long*)(nint)/*Error near IL_000f: Stack underflow*/ = num;
			/*Error near IL_0010: Invalid metadata token*/;
		}
		set; }

	internal unsafe Class6()
	{
		//Discarded unreachable code: IL_0018, IL_001d, IL_0022
		//IL_0005: Expected F4, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			nuint num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
			_003F val = /*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
			*(float*)(nint)/*Error near IL_0005: Stack underflow*/ = (nint)num >> (int)val;
		}
		while (/*Error near IL_000a: Stack underflow*/ == /*Error near IL_000a: Stack underflow*/);
		_ = -3.512313253547184E-225;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	static extern Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0);

	static extern Assembly smethod_1(Type type_0);

	static extern ResourceManager smethod_2(string string_0, Assembly assembly_0);
}
