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
		int object.GetHashCode()
		{
			//IL_0006: Expected I4, but got Unknown
			/*OpCode not supported: Ckfinite*/;
			checked
			{
				_ = (ulong)/*Error near IL_0002: Stack underflow*/;
				_ = 1;
			}
			return (int)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal extern Type method_0();

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		extern string object.ToString();

		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_001a
			//IL_0009: Expected I8, but got I4
			//IL_0015: Invalid comparison between I4 and F4
			/*Error: Invalid metadata token*/;
		}

		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			//Discarded unreachable code: IL_0001, IL_0007, IL_000d, IL_0017, IL_001e, IL_0024, IL_0029, IL_002b, IL_002c
			//IL_0002: Invalid comparison between Unknown and I
			//IL_0012: Incompatible stack heights: 0 vs 1
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Unknown opcode: 0xFF*/;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class8();

		static object smethod_1(object object_0)
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_000a, IL_000b, IL_0012, IL_001f
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
			}
			checked
			{
				_ = (ulong)/*Error near IL_0006: Stack underflow*/;
				/*Error near IL_0006: Unknown opcode: 0xFB*/;
			}
		}

		extern bool method_2(object object_0);

		extern int method_3();

		static extern Type smethod_2(RuntimeTypeHandle runtimeTypeHandle_0);

		extern string method_4();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class9<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;

		internal extern T Prop_0
		{
			[DebuggerHidden]
			get;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class9();
	}

	private static readonly Class9<Class6> class9_0;

	private static readonly Class9<Class5> class9_1;

	private static readonly Class9<User> class9_2;

	private static readonly Class9<Class8> class9_3;

	[HelpKeyword("My.Computer")]
	internal static extern Class6 Class6_0
	{
		[DebuggerHidden]
		get;
	}

	[HelpKeyword("My.Application")]
	internal static extern Class5 Class5_0
	{
		[DebuggerHidden]
		get;
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
