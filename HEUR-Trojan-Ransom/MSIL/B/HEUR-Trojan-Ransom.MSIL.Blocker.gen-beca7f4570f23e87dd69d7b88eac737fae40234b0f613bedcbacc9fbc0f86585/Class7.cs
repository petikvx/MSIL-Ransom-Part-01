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
			//Discarded unreachable code: IL_0009
			sbyte num = checked((sbyte)/*Error near IL_0002: Stack underflow*/);
			_ = ((byte[])/*Error near IL_0003: Stack underflow*/)[num];
			/*Error near IL_0004: Invalid metadata token*/;
		}

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
			//Discarded unreachable code: IL_0005
			/*Error: Invalid metadata token*/;
		}

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

		internal extern T Prop_0
		{
			[DebuggerHidden]
			get;
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class9()
		{
			//Discarded unreachable code: IL_0005
			/*Error: Invalid metadata token*/;
		}
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
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0006, IL_000e, IL_0015, IL_001c, IL_0025
			_ = ((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static Class8 Class8_0
	{
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0006, IL_000b, IL_0012, IL_001c, IL_0026
			//IL_0021: Invalid comparison between Unknown and F4
			//IL_002b: Expected I4, but got F8
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			checked
			{
				_ = (nuint)/*Error near IL_0001: Stack underflow*/;
				/*Error near IL_0001: Invalid metadata token*/;
			}
		}
	}
}
