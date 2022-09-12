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
		internal Type method_0()
		{
			//Discarded unreachable code: IL_0005, IL_000c, IL_000e, IL_0016, IL_0021, IL_0030
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_001c: Incompatible stack heights: 0 vs 1
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			/*Error: Invalid metadata token*/;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		string object.ToString()
		{
			//Discarded unreachable code: IL_0005, IL_000e, IL_000f
			//IL_0009: Incompatible stack heights: 0 vs 1
			/*Error: Invalid metadata token*/;
		}

		[DebuggerHidden]
		private static extern T smethod_0<T>(T gparam_0) where T : new();

		[DebuggerHidden]
		private extern void method_1<T>(ref T gparam_0);

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public extern Class8();

		static extern object smethod_1(object object_0);

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

		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				//Discarded unreachable code: IL_0002, IL_0008
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				_ = ((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
				/*Error near IL_0001: Unknown opcode: 0xFB*/;
			}
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
