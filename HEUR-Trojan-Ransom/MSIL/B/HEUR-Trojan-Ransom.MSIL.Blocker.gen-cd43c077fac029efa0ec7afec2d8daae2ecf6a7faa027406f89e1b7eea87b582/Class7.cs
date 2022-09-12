using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "14.0.0.0")]
internal sealed class Class7
{
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class Class8
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		extern bool object.Equals(object obj);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		extern int object.GetHashCode();

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal extern Type method_0();

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		extern string object.ToString();

		[DebuggerHidden]
		private static extern T smethod_0<T>(T gparam_0) where T : new();

		[DebuggerHidden]
		private extern void method_1<T>(ref T gparam_0);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class8()
		{
			//Discarded unreachable code: IL_0006, IL_0011, IL_0015, IL_001b, IL_0022
			//IL_0013: Invalid comparison between Unknown and I4
			//IL_0013: Incompatible stack heights: 1 vs 0
			//IL_0022: Unsupported input type for neg.
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected native int or pointer, but got F4
			//IL_002f: Expected F4, but got I4
			/*Error: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}

		static extern object smethod_1(object object_0);

		extern bool method_2(object object_0);

		extern int method_3();

		unsafe static Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			//Discarded unreachable code: IL_0003, IL_0009
			//IL_0005: Expected O, but got I4
			_ = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xFB*/;
		}

		extern string method_4();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class9<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				//Discarded unreachable code: IL_0013
				//IL_0008: Unknown result type (might be due to invalid IL or missing references)
				while (true)
				{
					if (checked((nint)/*Error near IL_0002: Stack underflow*/) == 4)
					{
						_003F val = /*Error near IL_0009: Stack underflow*/% /*Error near IL_0009: Stack underflow*/;
						if (/*Error near IL_000e: Stack underflow*/ > val)
						{
							break;
						}
					}
				}
				/*Error near IL_000e: Invalid metadata token*/;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class9()
		{
			//Discarded unreachable code: IL_0006, IL_0011, IL_0015, IL_001b, IL_0022
			//IL_0013: Invalid comparison between Unknown and I4
			//IL_0013: Incompatible stack heights: 1 vs 0
			//IL_0022: Unsupported input type for neg.
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected native int or pointer, but got F4
			//IL_002f: Expected F4, but got I4
			/*Error: stloc 1 (out-of-bounds)*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	private static readonly Class9<Class6> class9_0;

	private static readonly Class9<Class5> class9_1;

	private static readonly Class9<User> class9_2;

	private static readonly Class9<Class8> class9_3;

	[HelpKeyword("My.Computer")]
	internal unsafe static Class6 Class6_0
	{
		[DebuggerHidden]
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected I4, but got Unknown
			while (true)
			{
				if ((nint)checked((nuint)/*Error near IL_0001: Stack underflow*/) <= (nint)(-1))
				{
					continue;
				}
				_003F val = /*Error near IL_0009: Stack underflow*/& /*Error near IL_0009: Stack underflow*/;
				if (/*Error near IL_000e: Stack underflow*/ != val)
				{
					_003F val2;
					checked
					{
						int num = (int)(*unchecked((float*)(int)(*(uint*)(int)(ushort)/*Error near IL_000f: Stack underflow*/)));
						val2 = /*Error near IL_0013: Stack underflow*/* num;
					}
					*(sbyte*)(nint)/*Error near IL_0014: Stack underflow*/ = (sbyte)(int)val2;
					if (/*Error near IL_001b: Stack underflow*/ <= /*Error near IL_001b: Stack underflow*/)
					{
					}
				}
			}
		}
	}

	[HelpKeyword("My.Application")]
	internal static Class5 Class5_0
	{
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0006
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	[HelpKeyword("My.User")]
	internal static extern User User_0
	{
		[DebuggerHidden]
		get;
	}

	[HelpKeyword("My.WebServices")]
	internal static extern Class8 Class8_0
	{
		[DebuggerHidden]
		get;
	}
}
