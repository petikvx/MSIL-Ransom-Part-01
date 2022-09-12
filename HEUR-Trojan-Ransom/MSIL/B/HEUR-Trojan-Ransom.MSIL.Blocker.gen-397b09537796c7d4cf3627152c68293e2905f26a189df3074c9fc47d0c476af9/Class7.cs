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
		string object.ToString()
		{
			//Discarded unreachable code: IL_0005
			while (true)
			{
			}
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

		internal unsafe T Prop_0
		{
			[DebuggerHidden]
			get
			{
				//Discarded unreachable code: IL_0016, IL_001f
				//IL_000c: Expected I4, but got I8
				//IL_0010: Expected I4, but got I8
				while (true)
				{
					((short[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/] = -1;
					ulong num = checked((ulong)/*Error near IL_000f: Stack underflow*/);
					*(sbyte*)(nint)/*Error near IL_0010: Stack underflow*/ = (sbyte)num;
					*(_003F*)(nint)/*Error near IL_0011: Stack underflow*/ = /*Error near IL_0011: Stack underflow*/;
				}
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
	internal unsafe static User User_0
	{
		[DebuggerHidden]
		get
		{
			//Discarded unreachable code: IL_0008, IL_002f, IL_0034, IL_003a
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected I, but got O
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			_ = *(int*)(nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static extern Class8 Class8_0
	{
		[DebuggerHidden]
		get;
	}
}
