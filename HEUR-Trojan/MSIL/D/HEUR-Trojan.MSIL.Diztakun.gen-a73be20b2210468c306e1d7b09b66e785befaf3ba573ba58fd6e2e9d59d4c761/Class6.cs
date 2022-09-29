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
		get
		{
			//Discarded unreachable code: IL_0024, IL_002b, IL_0030
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Invalid comparison between Unknown and I4
			//IL_000d: Unsupported input type for neg.
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 1
			//IL_0018: Unsupported input type for neg.
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Invalid comparison between Unknown and F4
			//IL_0033: Expected O, but got I4
			while (true)
			{
				_003F val = /*Error near IL_0001: ldloc 0 (out-of-bounds)*/;
				int num = *(int*)(nint)(/*Error near IL_0003: Stack underflow*/ << (int)val);
				if ((int)/*Error near IL_0009: Stack underflow*/ < num)
				{
					continue;
				}
				checked
				{
					_ = (int)/*Error near IL_000c: Stack underflow*/;
				}
				if (0 - /*Error near IL_000c: ldloc 2 (out-of-bounds)*/== /*Error near IL_000e: ldloc 0 (out-of-bounds)*/)
				{
					/*OpCode not supported: DebugBreak*/;
					if (0 - /*Error near IL_0017: ldarg 0 (out-of-bounds)*/!= 0)
					{
						break;
					}
				}
			}
			/*Error near IL_001f: Invalid metadata token*/;
		}
		set; }

	internal extern Class6();

	static extern Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0);

	unsafe static Assembly smethod_1(Type type_0)
	{
		//Discarded unreachable code: IL_000e, IL_0014, IL_0019, IL_001e, IL_001f, IL_0027, IL_002f
		//IL_0002: Expected O, but got F8
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I4, but got I8
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		nint num = (nint)((Array)(double)/*Error near IL_0001: Stack underflow*/).LongLength;
		_003F val = /*Error near IL_0005: Stack underflow*/% (num | 0);
		*(int*)(nint)/*Error near IL_0008: Stack underflow*/ = (int)(~(ulong)val);
		checked
		{
			_ = (uint)/*Error near IL_0009: Stack underflow*/;
			/*Error near IL_0009: Invalid metadata token*/;
		}
	}

	static extern ResourceManager smethod_2(string string_0, Assembly assembly_0);
}
